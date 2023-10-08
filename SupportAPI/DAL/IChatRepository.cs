using System;
using System.Collections.Generic;
using SupportAPI.Common.Entities;

namespace SupportAPI.DAL;

public interface IChatRepository : IDisposable
{
    
    IEnumerable<Chat> GetChats();
    IQueryable<Chat> GetQueryableChats();
    Chat GetChatById(int chatId);
    void InsertChat(Chat chatObj);
    void DeleteChat(int chatId);
    void UpdateChat(Chat chatObj);
    void Save();
}





