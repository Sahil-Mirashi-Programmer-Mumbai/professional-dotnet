// Program to demonstrate Custom Event Arguments with Multiple Properties in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Complex Event Data: Custom arguments for complex data.
    Timestamping and Data Tracking: Useful for event auditing.
*/

namespace CustomEventArgumentsWithMultipleProperties_01
{
    // Custom EventArgs class with multiple properties
    public class AdvancedEventArgs : EventArgs
    {
        public string Message { get; }
        public DateTime Timestamp { get; }

        public AdvancedEventArgs(string message, DateTime timestamp)
        {
            Message = message;
            Timestamp = timestamp;
        }
    }

    public class Publisher
    {
        public event EventHandler<AdvancedEventArgs> AdvancedEvent;

        public void RaiseEvent(string message)
        {
            AdvancedEvent?.Invoke(this, new AdvancedEventArgs(message, DateTime.Now));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Custom Event Arguments with Multiple Properties in C# with Visual Studio\n");

            Publisher publisher = new Publisher();

            // Subscribing with a method that matches the signature
            publisher.AdvancedEvent += OnAdvancedEvent;

            // Raising the event
            publisher.RaiseEvent("Event with timestamp!");
        }

        private static void OnAdvancedEvent(object sender, AdvancedEventArgs e)
        {
            Console.WriteLine($"Message: {e.Message}, Timestamp: {e.Timestamp}");
        }
    }
}