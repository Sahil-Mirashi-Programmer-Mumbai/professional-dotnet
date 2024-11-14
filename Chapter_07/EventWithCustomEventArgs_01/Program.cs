// Program to demonstrate Event with Custom Event Args in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Custom EventArgs: Derived from EventArgs to pass data with events.
    Generic EventHandler<T>: Allows passing custom data with events (EventHandler<CustomEventArgs>).
    Data Passing: Useful for providing additional context during an event.
*/

namespace EventWithCustomEventArgs_01
{
    // Custom EventArgs to pass additional data with the event
    public class CustomEventArgs : EventArgs
    {
        public string Message { get; }

        public CustomEventArgs(string message)
        {
            Message = message;
        }
    }

    // Publisher class that declares an event
    public class Publisher
    {
        public event EventHandler<CustomEventArgs> CustomEvent;

        public void RaiseEvent(string message)
        {
            // Raise the event with custom arguments
            CustomEvent?.Invoke(this, new CustomEventArgs(message));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Event with Custom Event Args in C# with Visual Studio\n");

            Publisher publisher = new Publisher();

            // Subscribing to the event with a method that matches the event signature
            publisher.CustomEvent += OnCustomEvent;

            // Triggering the event with a custom message
            publisher.RaiseEvent("Hello, Custom Event!"); // Output: Received message: Hello, Custom Event!
        }

        // Event handler method that matches the event signature
        private static void OnCustomEvent(object sender, CustomEventArgs e)
        {
            Console.WriteLine($"Received message: {e.Message}");
        }
    }
}