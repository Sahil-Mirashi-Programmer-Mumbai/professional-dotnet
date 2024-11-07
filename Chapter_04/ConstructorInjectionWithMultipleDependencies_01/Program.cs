// Program to demonstrate Constructor Injection With Multiple Dependencies in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace ConstructorInjectionWithMultipleDependencies_01
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

    class SmsService: IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }
    }

    class Notification
    {
        private readonly IMessageService _primaryService;
        private readonly IMessageService _backupService;

        public Notification(IMessageService primaryService, IMessageService backupService)
        {
            _primaryService = primaryService;
            _backupService = backupService;
        }

        public void Notify(string message)
        {
            _primaryService.SendMessage(message);
            _backupService.SendMessage(message);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Constructor Injection With Multiple Dependencies in C# with Visual Studio\n");

            IMessageService emailService = new EmailService();
            IMessageService smsService = new SmsService();

            Notification notification = new Notification(emailService, smsService);
            notification.Notify("Dependency injection with multiple services");
        }
    }
}
