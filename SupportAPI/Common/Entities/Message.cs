namespace SupportAPI.Common.Entities;

public class Message
{
    public Guid Id { get; set; }
    public User User { get; set; }
    public string AuthorId { get; set; }
    public bool IsAgent { get;  set; } //todo make function
    public required string Text { get; set; }
    public DateTime SentAt { get; set; }
}