using Core;
using System;

namespace RabbitProcessorLibrary
{
    public class RabbitMQProcessor : Processor
    {
        protected override IMessage GetMessage()
        {
            // use rabbit mq.dlls and classes to get message from rabbit mq instance
            Console.WriteLine("Message retrieved from RabbitMQ");
            return new RabbitMQMessage(); // this line is added to make solution built
        }
    }

    public class RabbitMQMessage : IMessage { }
}
