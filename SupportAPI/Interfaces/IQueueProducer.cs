namespace SupportAPI.Interfaces;

public interface IQueueProducer
{
    public Task PublishMessageToQueueAsync<T> (T message);
    public int GetMessageCount();
}