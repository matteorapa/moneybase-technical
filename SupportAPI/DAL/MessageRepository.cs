using SupportAPI.Common.Entities;
using SupportAPI.Helpers;

namespace SupportAPI.DAL;

public class MessageRepository : IMessageRepository
{
    private ApplicationDbContext context;

    public MessageRepository(ApplicationDbContext context)
    {
        this.context = context;
    }

    public void InsertMessage(Message newMessage)
    {
        context.Messages.Add(newMessage);
    }

    public async Task SaveAsync()
    {
        await context.SaveChangesAsync();
    }
    
}