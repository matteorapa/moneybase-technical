namespace SupportAPI.Common.Enums;

public enum Status
{
    Opened, // once opened a chat can be either queued to an agent or rejected
    Queued,
    Rejected,
    Active,
    Closed
}