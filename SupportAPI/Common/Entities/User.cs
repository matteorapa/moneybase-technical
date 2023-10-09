using System.ComponentModel.DataAnnotations;

namespace SupportAPI.Common.Entities;

public class User
{
    [Key]
    public string Id { get; set; }
    public List<Chat>? Chats { get; set; }
}