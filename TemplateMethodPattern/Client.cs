using Core;
using MSMQProcessorLibrary;
using RabbitProcessorLibrary;
using System;
using WebSphereMQProcessorLibrary;

namespace TemplateMethodPattern
{
    public class Client
    {
        public static void Main()
        {
            Processor processor = new MSMQProcessor();
            processor.Execute();

            Console.WriteLine("-----------------------");

            Processor processor2 = new RabbitMQProcessor();
            processor2.Execute();

            Console.WriteLine("-----------------------");

            Processor processor3 = new WebSphereMQProcessor();
            processor3.Execute();


            Console.ReadKey();
        }
    }
}
