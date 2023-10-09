namespace SupportAPI.Common.Entities;

public class Message
{
    public Guid Id { get; set; }
    public User User { get; set; }
    public string UserId { get; set; }
    public bool IsSentByAgent { get;  set; }
    public required string Text { get; set; }
    public DateTime SentAt { get; set; }
}