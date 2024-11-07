// Program to demonstrate Property Dependency Injection in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace PropertyDependencyInjection_01
{
    interface IMessageService
    {
        void SendMessage(string message);
    }

    class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }

    class Notification
    {
        public IMessageService MessageService { get; set; }

        public void Notify(string message)
        {
            MessageService?.SendMessage(message);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Property Dependency Injection in C# with Visual Studio\n");

            Notification notification = new Notification
            {
                MessageService = new EmailService()
            };

            notification.Notify("Dependency injection with property");
        }
    }
}
