using SupportAPI.Common.Entities;

namespace SupportAPI.DAL;

public interface IMessageRepository
{
    public void InsertMessage(Message newMessage);
    public Task SaveAsync();
}