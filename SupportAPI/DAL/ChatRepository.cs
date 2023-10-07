using Microsoft.EntityFrameworkCore;
using SupportAPI.Common.Entities;
using SupportAPI.Helpers;

namespace SupportAPI.DAL;

public class ChatRepository
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

    public Chat GetChatByID(int id)
    {
        return context.Chats.Find(id);
    }

    public void InsertChat(Chat Chat)
    {
        context.Chats.Add(Chat);
    }

    public void DeleteChat(int ChatID)
    {
        Chat Chat = context.Chats.Find(ChatID);
        context.Chats.Remove(Chat);
    }

    public void UpdateChat(Chat Chat)
    {
        context.Entry(Chat).State = EntityState.Modified;
    }

    public void Save()
    {
        context.SaveChanges();
    }
}