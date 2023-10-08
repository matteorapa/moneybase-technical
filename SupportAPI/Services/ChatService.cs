using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
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
    private readonly IMapper _mapper;

    public ChatService(IChatRepository chatRepository, IMapper mapper, ITeamService teamService)
    {
        _mapper = mapper;
        _teamService = teamService;
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
                OpenedAt = DateTime.Now
            };
        
            _chatRepository.InsertChat(newChat);
            _chatRepository.Save();
        
        
            var model = _mapper.Map<ChatResultModel>(newChat);

            double maxQueueCapacity = 0;
            // first check if queue is at capacity based on active agents
            var currentTeamWorking = await _teamService.GetCurrentTeam(DateTime.Now);
            
            // check if overflow team is active
            var isOverflowTeamActive = await _teamService.CheckIsOverflowTeamWorking();
            if (isOverflowTeamActive)
            {
                var overflowTeam = await _teamService.GetOverflowTeam();
                var overflowTeamCapacity = _teamService.CalculateCapacityForTeam(overflowTeam);
                maxQueueCapacity += overflowTeamCapacity;
            }
            
            var teamCapacity = _teamService.CalculateCapacityForTeam(currentTeamWorking);
            maxQueueCapacity += teamCapacity; 
            const double capacityMultiplier = 1.5; //todo add in appsettings.json
            maxQueueCapacity = maxQueueCapacity * capacityMultiplier;
           
            var currentQueueCount = 0; // the amount of support requests waiting in the queue

            // compare with requests count in queue, either queue or reject the new chat
            if (currentQueueCount >= maxQueueCapacity)
            {
                // reject the support request due to many demand
                newChat.Status = Status.Rejected;
                _chatRepository.UpdateChat(newChat);
                _chatRepository.Save();
                
                // get overflow team online
                await _teamService.RequestOverflowTeam();
            }
            else
            {
                newChat.Status = Status.Queued;
                //todo place in queue
            }
            
            
            return model;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }
    
    public async Task<List<ChatResultModel>> FetchAllChatsForAgent(string agentId)
    {
        var chats =  _chatRepository.GetChats().ToList();
        var models = _mapper.Map<List<ChatResultModel>>(chats);
        return models;
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

        foreach (var chat in queuedChats)
        {
            
        }
        
        foreach (var agent in agentsWorking)
        {
            
        }
        
        
        
        throw new NotImplementedException();
    }
}