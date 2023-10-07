using AutoMapper;
using Microsoft.EntityFrameworkCore.Infrastructure;
using SupportAPI.Common.Entities;
using SupportAPI.Common.Models;
using SupportAPI.DAL;
using SupportAPI.Interfaces;

namespace SupportAPI.Services;

public class ChatService : IChatService
{
    
    private IChatRepository _chatRepository;
    private readonly IMapper _mapper;

    public ChatService(IChatRepository chatRepository, IMapper mapper)
    {
        _mapper = mapper;
        this._chatRepository = chatRepository;
    }


    public ChatResultModel InitiateSupportRequest(string customerId)
    {
        try
        {
            var newChat = new Chat()
            {
                Id = Guid.NewGuid()
            };
        
            _chatRepository.InsertChat(newChat);
            _chatRepository.Save();
        
        
            var model = _mapper.Map<ChatResultModel>(newChat);
            return model;
            
            // first check if queue is at capacity based on active agents
            
            // compare with requests count in queue
            
            // queue or reject the new chat
            
            //todo place in queue
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }
    
    public List<ChatResultModel> FetchAllChatsForAgent(string agentId)
    {
        var chats =  _chatRepository.GetChats().ToList();
        var models = _mapper.Map<List<ChatResultModel>>(chats);
        return models;
    }
    
    
   
}