using SupportAPI.Common.Enums;

namespace SupportAPI.Common.Entities;

public class Agent : User
{
    public Seniority Seniority { get; set; }
    
    public Team Team { get; set; }
    public Guid TeamId { get; set; } 
    public bool IsOnline { get; set; }
    
    public List<Chat> Chats { get; set; }
}