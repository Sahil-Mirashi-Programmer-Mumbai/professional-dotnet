// Program to demonstrate Method Dependency Injection in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace MethodDependencyInjection_01
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
        public void Notify(string message, IMessageService messageService)
        {
            messageService.SendMessage(message);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Method Dependency Injection in C# with Visual Studio\n");

            IMessageService messageService = new EmailService();
            Notification notification = new Notification();

            notification.Notify("Dependency injection with method", messageService);
        }
    }
}
