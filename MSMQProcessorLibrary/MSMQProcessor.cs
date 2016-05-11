using Core;
using System;

namespace MSMQProcessorLibrary
{
    public class MSMQProcessor : Processor
    {
        protected override IMessage GetMessage()
        {
            // use msmq .dlls and classes to get message from msmq
            Console.WriteLine("Message retrieved from MSMQ");
            return new MsmqMessage(); // this line is added to make solution built
        }
    }

    public class MsmqMessage : IMessage { }
}
