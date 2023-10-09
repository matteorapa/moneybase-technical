namespace SupportAPI.Interfaces;

public interface IQueueConsumer
{
    Guid ConsumeMessageFromQueue();
}