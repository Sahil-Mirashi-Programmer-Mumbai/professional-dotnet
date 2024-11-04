// Program to demonstrate Using Interface For Dependency Injection in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace UsingInterfaceForDependencyInjection_01
{
    interface IMessageService
    {
        void SendMessage(string message);
    }

    class EmailMessage : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending message via email {message}");
        }
    }

    class SmsMessage : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending message via sms {message}");
        }
    }

    class Notification
    {
        private IMessageService _messageService;

        public Notification(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void Notify(string message)
        {
            _messageService.SendMessage(message);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Using Interface For Dependency Injection in C# with Visual Studio\n");

            Notification notification = new Notification(new EmailMessage());
            notification.Notify("Welcome to the world of programming"); // Output: Sending message via email Welcome to the world of programming
        }
    }
}
