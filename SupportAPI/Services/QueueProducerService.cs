using System.Text;
using Newtonsoft.Json;
using RabbitMQ.Client;
using SupportAPI.Interfaces;

namespace SupportAPI.Services;

public class QueueProducerService : IQueueProducer
{
    private IConfiguration _configuration;

    public QueueProducerService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public int GetMessageCount()
    {
        var factory = new ConnectionFactory {
            HostName = _configuration.GetSection("RabbitMq:Hostname").Value,
            Port = Convert.ToInt16(_configuration.GetSection("RabbitMq:Port").Value),
            UserName = _configuration.GetSection("RabbitMq:Username").Value,
            Password = _configuration.GetSection("RabbitMq:Password").Value
        };
        using (IConnection connection = factory.CreateConnection())
        using (IModel channel = connection.CreateModel())
        {
            return (int)channel.MessageCount(_configuration.GetSection("RabbitMq:QueueName").Value);
        }
    }
    public async Task PublishMessageToQueueAsync<T>(T message)
    {
        //Here we specify the Rabbit MQ Server. we use rabbitmq docker image and use it
        var factory = new ConnectionFactory {
            HostName = "localhost",
            Port = 5672,
            UserName = "guest",
            Password = "guest"
        };
        //Create the RabbitMQ connection using connection factory details as i mentioned above
        
        var connection = factory.CreateConnection();
        //Here we create channel with session and model
        
        
        // create exchange
        var model = connection.CreateModel();
        
        model.ExchangeDeclare("supportExchange", ExchangeType.Direct);
        
        //declare the queue after mentioning name and a few property related to that
        
        model.QueueDeclare("chatqueue", exclusive: false);
        
        model.QueueBind("chatqueue", "supportExchange", "chat");
        
        //Serialize the message
        var json = JsonConvert.SerializeObject(message);
        var body = Encoding.UTF8.GetBytes(json);
        //put the data on to the product queue
        model.BasicPublish(exchange: "supportExchange", routingKey: "chat", body: body);
    }
}


