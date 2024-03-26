using System.Text;
using RabbitMQ.Client;

namespace OrderAPI.Helper;

public class Notification
{
    // connect with RabbitMQ
    //private ConnectionFactory _connectionFactory;
    
    public Notification(ConnectionFactory connectionFactory)
    {
        //_connectionFactory = connectionFactory;
       
    }
    
    public void AddMessageToQueue(string msg)
    {
        ConnectionFactory _connectionFactory = new ConnectionFactory();
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
        //channel.QueueDeclare(queueName); // auto delete
        channel.QueueDeclare(queueName, false, false,false, null); // not auto delete
        // bind it
        channel.QueueBind(queueName, exchange, routingKey, null); // IDict is null
        byte[] messageBytes = Encoding.UTF8.GetBytes(msg);
        channel.BasicPublish(exchange, routingKey,null,messageBytes);
        channel.Close();
        conn.Close();
        // }
    
    
    }

    

}