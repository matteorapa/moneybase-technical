using Microsoft.EntityFrameworkCore;
using SupportAPI.Common.Entities;
using SupportAPI.Common.Enums;
using SupportAPI.Common.Models;
using SupportAPI.Helpers;

namespace SupportAPI.DAL;

public class ChatRepository : IChatRepository
{
    private ApplicationDbContext context;

    public ChatRepository(ApplicationDbContext context)
    {
        this.context = context;
    }

    public IEnumerable<Chat> GetChats()
    {
        return context.Chats.ToList();
    }
    
    public async Task<List<UserQueryModel>> GetChatCountForAgents(List<string> agentIds)
    {
        var models = await context.Agents.Where(a => agentIds.Contains(a.Id))
            .Include(u => u.Chats)
            .Select(u => new UserQueryModel()
            {
                Id = u.Id,
                Seniority = u.Seniority,
                ChatCount = u.Chats.Count(c => c.Status == Status.Queued)
            }).ToListAsync();

        return models;
    }

    public IQueryable<Chat> GetQueryableChats()
    {
        return context.Chats;
    }

    public Chat GetChatById(int chatId)
    {
        throw new NotImplementedException();
    }

    public Chat GetChatByID(int id)
    {
        return context.Chats.Find(id);
    }

    public void InsertChat(Chat chat)
    {
        context.Chats.Add(chat);
    }

    public void DeleteChat(int chatID)
    {
        Chat chat = context.Chats.Find(chatID);
        context.Chats.Remove(chat);
    }

    public void UpdateChat(Chat chat)
    {
        context.Entry(chat).State = EntityState.Modified;
    }

    public void Save()
    {
        context.SaveChanges();
    }
    
    public async Task SaveAsync()
    {
       await context.SaveChangesAsync();
    }
    
}