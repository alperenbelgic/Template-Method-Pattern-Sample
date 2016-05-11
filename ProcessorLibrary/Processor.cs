using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public abstract class Processor
    {
        public void Execute()
        {
            LogOperation();

            IMessage message = GetMessage();

            var processResult = ProcessMessage(message);

            if (true == processResult)
            {
                TriggerCompletedEvent(message);
            }
        }

        private void LogOperation()
        {
            Console.WriteLine("Message processing.");
        }

        protected abstract IMessage GetMessage();

        private bool ProcessMessage(IMessage message)
        {
            // Invoke proper methods by reading message content.
            Console.WriteLine("Message processed");
            return true;
        }

        private void TriggerCompletedEvent(IMessage message)
        {
            Console.WriteLine("Event triggered.");
        }

    }

    public interface IMessage
    {
    }
}
