using SupportAPI.Common.Models;

namespace SupportAPI.Interfaces;

public interface IChatService
{
    public ChatResultModel InitiateSupportRequest(string customerId);
    public List<ChatResultModel> FetchAllChatsForAgent(string agentId);
}