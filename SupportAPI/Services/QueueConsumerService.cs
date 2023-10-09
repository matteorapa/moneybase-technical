using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using SupportAPI.Interfaces;

namespace SupportAPI.Services;

public class QueueConsumerService : IQueueConsumer
{
    private IConfiguration _configuration;
    private IModel _model;

    public QueueConsumerService(IConfiguration configuration)
    {
        _configuration = configuration;
        _model = CreateConnectionToChannel();
        Setup(_model);
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
    
    public Guid ConsumeMessageFromQueue()
    {
        var chatId = "";
        var consumer = new EventingBasicConsumer(_model);
        
        consumer.Received += (model, eventArgs) => {
            var body = eventArgs.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);
            chatId = message;
        };
        
        _model.BasicConsume(queue: "chatQueue", autoAck: true, consumer: consumer);
        
        //todo issue here chatId not updating
        return Guid.Parse(chatId);
    }
}