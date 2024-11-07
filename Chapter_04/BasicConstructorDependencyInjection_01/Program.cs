// Program to demonstrate Basic Constructor Dependency Injection in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace BasicConstructorDependencyInjection_01
{
    // Define a Service Interface
    public interface IMessageService
    {
        void SendMessage(string message);
    }

    // Implement the Service
    public class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Email sent: " + message);
        }
    }

    // Create the class that depends on IMessageService - the service interface
    public class Notification
    {
        private readonly IMessageService _messageService;

        // Inject IMessageService dependency via constructor
        public Notification(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void Notify(string message)
        {
            _messageService.SendMessage(message);
        }
    } 

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Basic Constructor Dependency Injection in C# with Visual Studio\n");

            // Manual Dependency Injection: Pass an instance of EmailService
            IMessageService emailService = new EmailService();
            Notification notification = new Notification(emailService);

            notification.Notify("Hello via DI!");
        }
    }
}
