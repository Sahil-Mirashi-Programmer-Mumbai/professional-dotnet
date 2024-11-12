// Program to demonstrate using delegates for event handling in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Events: Built on delegates and allow the broadcasting of notifications.
    Event Subscription: Multiple methods can be subscribed to a single event.
*/

namespace UsingDelegatesForEventHandling_01
{
    // Delegate definition for an event
    public delegate void NotifyEventHandler(string message);

    class EventPublisher
    {
        // Declaring an event using delegate
        public event NotifyEventHandler Notify;

        // Method to trigger the event
        public void TriggerEvent(string message)
        {
            Notify?.Invoke(message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate using delegates for event handling in C# with Visual Studio\n");

            EventPublisher eventPublisher = new EventPublisher();

            // Subscribing methods to the event
            eventPublisher.Notify += MessageHandler;
            eventPublisher.Notify += AnotherHandler;

            // Triggering the event
            eventPublisher.TriggerEvent("Hello");
        }

        // Methods that match the NotifyEventHandler delegate
        public static void MessageHandler(string message)
        {
            Console.WriteLine($"Message Handler: {message}");
        }

        public static void AnotherHandler(string message)
        {
            Console.WriteLine($"Another Handler Handler: {message}");
        }
    }
}
