using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace InventoryAPI.Helper;

public class RabbitMqQueue
{
    // connect with RabbitMQ
    private ConnectionFactory _connectionFactory;
    
    public RabbitMqQueue(ConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }
    
    public void ReadMessage(Func<string, string> reader) // pass delegate
    {
        _connectionFactory.Uri = new Uri("amqp://guest:guest@10.0.0.80:5672"); // replace localhost to IP4 address
        _connectionFactory.ClientProvidedName = "Order Service";
        var conn = _connectionFactory.CreateConnection(); // use it create channel
        
        // auto call garbage collector
        // using (var conn = _connectionFactory.CreateConnection())
        // {
        var channel = conn.CreateModel();
        string exchange = "OrderAPIExchange";
        string routingKey = "order-api-routing-key";
        string queueName = "order-api-queue";
        channel.ExchangeDeclare(exchange, ExchangeType.Direct);
        channel.QueueDeclare(queueName);
        // bind it
        channel.QueueBind(queueName, exchange, routingKey); // IDict is null
        
        channel.BasicQos(0,1, false); // read it one by one ???? ********
        var consumer = new EventingBasicConsumer(channel);
        consumer.Received += (sender, args) =>
        {
            var body = args.Body.ToArray();
            string message = Encoding.UTF8.GetString(body); // decrypt
            reader(message); // add delegate here
            channel.BasicAck(args.DeliveryTag, false); // one passed to it
        };
        string str = channel.BasicConsume(queueName, false, consumer); 
        channel.BasicCancel(str);
        channel.Close();
        conn.Close();

    }
    
    
}