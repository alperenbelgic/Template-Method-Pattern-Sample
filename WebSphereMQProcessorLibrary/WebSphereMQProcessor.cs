using System;
using Core;

namespace WebSphereMQProcessorLibrary
{
    public class WebSphereMQProcessor : Processor
    {
        protected override IMessage GetMessage()
        {
            // use websphere mq.dlls and classes to get message from WebSphere 
            Console.WriteLine("Message retrieved from WebSphere MQ");
            return new WebSphereMQMessage(); // this line is added to make solution built
        }
    }

    public class WebSphereMQMessage : IMessage { }
}
