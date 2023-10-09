using System;
using System.Collections.Generic;
using SupportAPI.Common.Entities;
using SupportAPI.Common.Models;

namespace SupportAPI.DAL;

public interface IChatRepository
{
    
    IEnumerable<Chat> GetChats();
    IQueryable<Chat> GetQueryableChats();
    Task<List<UserQueryModel>> GetChatCountForAgents(List<string> agentIds);
    Chat GetChatById(int chatId);
    void InsertChat(Chat chatObj);
    void DeleteChat(int chatId);
    void UpdateChat(Chat chatObj);
    void Save();

    Task SaveAsync();
}





