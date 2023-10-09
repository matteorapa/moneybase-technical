using SupportAPI.Common.Enums;

namespace SupportAPI.Common.Entities;

public class Chat
{
    public Guid Id { get; set; }
    public Customer? Customer { get; set; }
    public string CustomerId { get; set; }
    
    public Agent? Agent { get; set; }
    public string? AgentId { get; set; }
    public Status Status { get; set; }
    public DateTime OpenedAt { get; set; }
    public DateTime ClosedAt { get; set; }
    public List<Message>? Messages { get; set; }
}