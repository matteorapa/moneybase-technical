namespace SupportAPI.Common.Entities;

public class Team
{
    public Guid Id { get; set; }
    public String Name { get; set; }
    public int MaxCapacity { get; set; }
    public bool IsOverflow { get; set; }
    public bool IsOnline { get; set; }
    public bool IsNightShift { get; set; }
    public DateTime StartAt { get;  set; }
    public DateTime FinishAt { get;  set; }
    public List<Agent> Agents { get; set; }
}