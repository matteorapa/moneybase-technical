namespace SupportAPI.Common.Entities;

public class Team
{
    public Guid Id { get; set; }
    public String Name { get; set; }
    public int MaxCapacity { get; set; }
    public bool overflow { get; set; }
    public bool IsOnline { get; set; }
    public bool IsNightShift { get; set; }
    public List<Agent> Agents { get; set; }
}