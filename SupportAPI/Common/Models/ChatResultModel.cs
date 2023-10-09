using SupportAPI.Common.Enums;

namespace SupportAPI.Common.Models;

public class ChatResultModel
{
    public Guid Id { get; set; }
    public string CustomerId { get; set; }
    public string AgentId { get; set; }
    public Status Status { get; set; }
    public DateTime OpenedAt { get; set; }
    public DateTime ClosedAt { get; set; }
}