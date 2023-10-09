using SupportAPI.Common.Models;

namespace SupportAPI.Interfaces;

public interface IMessageService
{
    public Task<bool> PostMessageToChat(Guid chatId, string userId, MessageInsertModel insertModel);
}