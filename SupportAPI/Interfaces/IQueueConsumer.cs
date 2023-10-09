namespace SupportAPI.Interfaces;

public interface IQueueConsumer
{
    Task<Guid> ConsumeMessageFromQueue();
}