using SupportAPI.Common.Enums;

namespace SupportAPI.Common.Models;

public class UserQueryModel
{
    public string Id { get; set; }
    public int ChatCount { get; set; }
    public Seniority Seniority { get; set; }
}