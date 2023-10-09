using System.Text;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using SupportAPI.Interfaces;

namespace SupportAPI.Services;

public class QueueProducerService : IQueueProducer
{
    private IConfiguration _configuration;
    private IModel _model;

    public QueueProducerService(IConfiguration configuration)
    {
        _configuration = configuration;
        _model = CreateConnectionToChannel();
        Setup(_model);
    }

    public int GetMessageCount()
    {
        using IModel channel = CreateConnectionToChannel();
        
        return (int)channel.MessageCount(_configuration.GetSection("RabbitMq:QueueName").Value);
    }

    private IModel CreateConnectionToChannel()
    {
        var factory = new ConnectionFactory {
            HostName = _configuration.GetSection("RabbitMq:Hostname").Value,
            Port = Convert.ToInt16(_configuration.GetSection("RabbitMq:Port").Value),
            UserName = _configuration.GetSection("RabbitMq:Username").Value,
            Password = _configuration.GetSection("RabbitMq:Password").Value
        };
        
        var connection = factory.CreateConnection();
        var model = connection.CreateModel();
        return model;
    }

    private void Setup(IModel connection)
    {
        using IModel model = CreateConnectionToChannel();
        var queueName = _configuration.GetSection("RabbitMq:QueueName").Value;
        var exchangeName = _configuration.GetSection("RabbitMq:ExchangeName").Value;
        var routingKey = _configuration.GetSection("RabbitMq:RoutingKey").Value;
        
        model.ExchangeDeclare(exchangeName, ExchangeType.Direct);
        model.QueueDeclare(queueName, exclusive: false);
        model.QueueBind(queueName, exchangeName, routingKey);
        
    }

    public async Task<Guid> ConsumeMessageFromQueue()
    {
       
        var consumer = new EventingBasicConsumer(_model);
        consumer.Received += (model, eventArgs) => {
            var body = eventArgs.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);
        };
        
        _model.BasicConsume(queue: "chatQueue", autoAck: true, consumer: consumer);
        
    }
    public async Task PublishMessageToQueueAsync<T>(T message)
    {
        var model = CreateConnectionToChannel();
        
        var exchangeName = _configuration.GetSection("RabbitMq:ExchangeName").Value;
        var routingKey = _configuration.GetSection("RabbitMq:RoutingKey").Value;
        
        //Serialize the message
        var json = JsonConvert.SerializeObject(message);
        var body = Encoding.UTF8.GetBytes(json);
        
        model.BasicPublish(exchange: exchangeName, routingKey: routingKey, body: body);
    }
}


