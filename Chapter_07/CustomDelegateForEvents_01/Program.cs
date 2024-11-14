// Program to demonstrate Custom Delegate for Events in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Custom Delegates: Allows custom event signatures.
    Delegate Flexibility: Useful for specialized scenarios.
*/

namespace CustomDelegateForEvents_01
{
    // Custom delegate definition
    public delegate void CustomDelegate(string message);

    public class Publisher
    {
        // Custom event handler
        public event CustomDelegate CustomEvent;

        // Event trigger
        public void RaiseEvent(string message)
        {
            CustomEvent?.Invoke(message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Custom Delegate for Events in C# with Visual Studio\n");

            Publisher publisher = new Publisher();

            // Subscribing to the custom event
            publisher.CustomEvent += MessageHandler;

            // Triggering the custom event
            publisher.RaiseEvent("Hello from custom delegate event!"); // Output: Message received: Hello from custom delegate event!
        }

        private static void MessageHandler(string message)
        {
            Console.WriteLine($"Message received: {message}");
        }
    }
}
