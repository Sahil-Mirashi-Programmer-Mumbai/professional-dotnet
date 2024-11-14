// Program to demonstrate Anonymous Event Handlers in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Anonymous Handlers: Use of lambda expressions for quick event handling without separate methods.
    Inline Logic: Ideal for simple, short-lived event handling logic.
*/

namespace AnonymousEventHandlers_01
{
    public class Publisher
    {
        public event EventHandler SimpleEvent;

        public void RaiseEvent()
        {
            SimpleEvent?.Invoke(this, EventArgs.Empty);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Anonymous Event Handlers in C# with Visual Studio\n");

            Publisher publisher = new Publisher();

            // Subscribing using an anonymous method (lambda expression)
            publisher.SimpleEvent += (sender, e) =>
            {
                Console.WriteLine("Event handled by anonymous method!");
            };

            // Triggering the event
            publisher.RaiseEvent(); // Output: Event handled by anonymous method!
        }
    }
}
