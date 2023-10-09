using SupportAPI.Common.Models;

namespace SupportAPI.Interfaces;

public interface IChatService
{
    public Task<ChatResultModel> InitiateSupportRequest(string customerId);
    public Task<List<ChatResultModel>> FetchAllChatsForAgent(string agentId);
    public Task<ChatResultModel> GetChat(Guid chatId);
    public Task AssignChatsFromQueue();

    public Task<bool> Close(Guid chatId);
}