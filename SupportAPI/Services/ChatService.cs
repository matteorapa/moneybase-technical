using System.Text;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using RabbitMQ.Client.Events;
using SupportAPI.Common.Entities;
using SupportAPI.Common.Enums;
using SupportAPI.Common.Models;
using SupportAPI.DAL;
using SupportAPI.Interfaces;

namespace SupportAPI.Services;

public class ChatService : IChatService
{
    
    private IChatRepository _chatRepository;
    private ITeamService _teamService;
    private IQueueProducer _queueProducer;
    private IQueueConsumer _queueConsumer;
    private readonly IMapper _mapper;
    private IConfiguration _configuration;

    public ChatService(IChatRepository chatRepository, IMapper mapper, ITeamService teamService, IQueueProducer queueProducer, IConfiguration configuration, IQueueConsumer queueConsumer)
    {
        _mapper = mapper;
        _teamService = teamService;
        _queueProducer = queueProducer;
        _configuration = configuration;
        _queueConsumer = queueConsumer;
        _chatRepository = chatRepository;
    }


    public async Task<ChatResultModel> InitiateSupportRequest(string customerId)
    {
        try
        {
            var newChat = new Chat()
            {
                Id = Guid.NewGuid(),
                CustomerId = customerId,
                OpenedAt = DateTime.Now,
                Status = Status.Rejected
            };
        
            _chatRepository.InsertChat(newChat);
            await _chatRepository.SaveAsync();
        
        
            var model = _mapper.Map<ChatResultModel>(newChat);

            double maxQueueCapacity = 0;
            // first check if queue is at capacity based on active agents
            var currentTeamWorking = await _teamService.GetCurrentTeam(DateTime.Now);
            
            if (currentTeamWorking.IsNightShift == false)
            {
                // only consider overflow team during the day
                
                // check if overflow team is active
                var isOverflowTeamActive = await _teamService.CheckIsOverflowTeamWorking();
                if (isOverflowTeamActive)
                {
                    var overflowTeam = await _teamService.GetOverflowTeam();
                    var overflowTeamCapacity = _teamService.CalculateCapacityForTeam(overflowTeam);
                    maxQueueCapacity += overflowTeamCapacity;
                }
            }
            
            var teamCapacity = _teamService.CalculateCapacityForTeam(currentTeamWorking);
            maxQueueCapacity += teamCapacity; 
            const double capacityMultiplier = 1.5; 
            
            maxQueueCapacity = maxQueueCapacity * capacityMultiplier;
            
            var currentQueueCount = 0; // the amount of support requests waiting in the queue
            currentQueueCount = _queueProducer.GetMessageCount();
            
            // compare with requests count in queue, either queue or reject the new chat
            if (currentQueueCount >= maxQueueCapacity)
            {
                // reject the support request due to many demand

                if (currentTeamWorking.IsNightShift == false)
                {
                    // get overflow team online
                    await _teamService.RequestOverflowTeam();
                    await AssignChatsFromQueue();
                }
            }
            else
            {
                newChat.Status = Status.Queued;
                _chatRepository.UpdateChat(newChat);
                await _chatRepository.SaveAsync();
                await _queueProducer.PublishMessageToQueueAsync(newChat.Id.ToString());
                
                // todo background job / console app
                await AssignChatsFromQueue();
            }
            
            
            return model;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    public async Task<List<ChatResultModel>> FetchAllChatsForAgent(string agentId)
    {
        var chats =  _chatRepository.GetChats().ToList();
        var models = _mapper.Map<List<ChatResultModel>>(chats);
        return models;
    }

    public async Task<ChatResultModel> GetChat(Guid chatId)
    {
        var chat = await _chatRepository.GetQueryableChats()
            .Where(c => c.Id == chatId).Include(c => c.Messages)
            .FirstOrDefaultAsync();
        return _mapper.Map<ChatResultModel>(chat);
    }

    
    public async Task AssignChatsFromQueue()
    {
        var agentsWorking = new List<Agent>();
        
        var currentTeamWorking = await _teamService.GetCurrentTeam(DateTime.Now);
        agentsWorking.AddRange(currentTeamWorking.Agents);
        
        // check if overflow team is active
        var isOverflowTeamActive = await _teamService.CheckIsOverflowTeamWorking();
        if (isOverflowTeamActive)
        {
            var overflowTeam = await _teamService.GetOverflowTeam();
            agentsWorking.AddRange(overflowTeam.Agents);
        }
        
        // get queued chats
        var queuedChats = await _chatRepository.GetQueryableChats()
            .Where(c => c.Status == Status.Queued)
            .ToListAsync();
        
        //todo use single thread safety
        
        //count opened assigned chats for each agent
        // if a slot is available in at least one agent,
        // assign to agent, by consuming from queue
        
        var agentIds = new List<string>();
        foreach (var agent in agentsWorking)
        {
            agentIds.Add(agent.Id);
        }
        var models = await _chatRepository.GetChatCountForAgents(agentIds);
        var modelsOrdered = models.OrderBy(m => m.Seniority).ToList();
        
        foreach (var agent in modelsOrdered)
        {
            var maxAgentCapacity = _teamService.GetCapacityForSeniority(agent.Seniority);
            if (agent.ChatCount < maxAgentCapacity)
            {
                // agent has capacity for at least one more chat
                await ConsumeAndAssign(agent.Id);
                break;
            }
        }
    }

    private async Task ConsumeAndAssign(string agentId)
    {
        // consume
        var chatId = _queueConsumer.ConsumeMessageFromQueue();
        // update status for chat
        var chat = await _chatRepository.GetQueryableChats().FirstOrDefaultAsync(c => c.Id == chatId);
        if (chat is not null)
        {
            chat.Status = Status.Opened;
            chat.AgentId = agentId;
            _chatRepository.UpdateChat(chat);
            await _chatRepository.SaveAsync();
        }
    }

    public async Task<bool> Close(Guid chatId)
    {
        var chat = await _chatRepository.GetQueryableChats().FirstOrDefaultAsync(c => c.Id == chatId);
        if (chat is not null)
        {
            chat.Status = Status.Closed;
        
            _chatRepository.UpdateChat(chat);
            await _chatRepository.SaveAsync();

            await AssignChatsFromQueue();
            return true;
        }
        return false;
    }
}