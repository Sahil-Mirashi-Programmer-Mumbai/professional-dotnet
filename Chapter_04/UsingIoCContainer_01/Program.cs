// Program to demonstrate Using IoC Container in C# with Visual Studio
// Programmer: Sahil Mirashi

using Microsoft.Extensions.DependencyInjection;

namespace UsingIoCContainer_01
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
        private protected IMessageService _messageService;

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
            Console.WriteLine("Program to demonstrate Using IoC Container in C# with Visual Studio\n");

            var services = new ServiceCollection();
            services.AddTransient<IMessageService, EmailService>();
            services.AddTransient<Notification>();

            var serviceProvider = services.BuildServiceProvider();

            var notification = serviceProvider.GetService<Notification>();
            notification?.Notify("Dependency injection with IoC Container"); // Output: Email sent: Dependency injection with IoC Container
        }
    }
}
