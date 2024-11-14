// Program to demonstrate Unsubscribing from Events in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Event Unsubscription: Remove handlers to prevent memory leaks and unintended behavior.
    Event Lifecycle Management: Important in dynamic applications.
*/

namespace UnsubscribingFromEvents_01
{
    public class Publisher
    {
        public event EventHandler CustomEvent;

        public void RaiseEvent()
        {
            CustomEvent?.Invoke(this, EventArgs.Empty);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Unsubscribing from Events in C# with Visual Studio\n");

            Publisher publisher = new Publisher();

            // Subscribing to the event
            EventHandler handler = OnEvent;
            publisher.CustomEvent += handler;

            // Triggering the event
            publisher.RaiseEvent(); // Output: Event handled!

            // Unsubscribing from the event
            publisher.CustomEvent -= handler;

            // Triggering the event again (no output)
            publisher.RaiseEvent();
        }

        private static void OnEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Event handled!");
        }
    }
}
