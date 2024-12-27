/*
Definition:
The Bridge Pattern decouples an abstraction from its implementation, allowing them to evolve independently. 
It is used to separate the interface (abstraction) from its implementation details.

Applications:
When there are multiple possible implementations for an abstraction.
When changes in the implementation should not affect the abstraction.
*/

namespace BridgePatternExample
{
    // Implementor interface
    public interface IMessageSender
    {
        void SendMessage(string message);
    }

    // Concrete Implementor A
    public class EmailSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }

    // Concrete Implementor B
    public class SmsSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }
    }

    // Abstraction
    public abstract class Message
    {
        protected IMessageSender _messageSender;

        protected Message(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public abstract void Send(string message);
    }

    // Refined Abstraction
    public class AlertMessage : Message
    {
        public AlertMessage(IMessageSender messageSender) : base(messageSender) { }

        public override void Send(string message)
        {
            _messageSender.SendMessage($"[ALERT] {message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Send an email alert
            IMessageSender emailSender = new EmailSender();
            Message emailAlert = new AlertMessage(emailSender);
            emailAlert.Send("Bridge Pattern in Action!");

            // Send an SMS alert
            IMessageSender smsSender = new SmsSender();
            Message smsAlert = new AlertMessage(smsSender);
            smsAlert.Send("Bridge Pattern with SMS!");

            Console.ReadLine();
        }
    }
}

/*
Explanation of Code:
Implementor (IMessageSender):
Declares the interface for implementation classes.

Concrete Implementors (EmailSender, SmsSender):
Provide specific implementations.

Abstraction (Message):
Defines the high - level interface that uses the implementor.

Refined Abstraction (AlertMessage):
Extends the abstraction, adding more functionality.

Client (Main Method):
Works with the abstraction without being tied to specific implementations.
*/