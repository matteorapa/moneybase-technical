namespace SupportAPI.Common.Entities;

public class Customer : User
{
    public Guid AccountId { get; set; }
}