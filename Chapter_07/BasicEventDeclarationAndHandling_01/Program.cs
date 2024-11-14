// Program to demonstrate Basic Event Declaration and Handling in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Event Handling
    In C#, events provide a way for objects to notify other objects when something of interest occurs. 
    Events follow the publisher-subscriber model, where a publisher raises an event and a subscriber listens for it and responds. 
    This is fundamental in GUI applications, asynchronous programming, and more.

    Event Declaration: public event EventHandler SimpleEvent; declares an event.
    EventHandler Delegate: A built-in delegate for events that don't need custom arguments.
    Event Invocation: SimpleEvent?.Invoke(this, EventArgs.Empty); safely raises the event if there are subscribers.
    Subscription: publisher.SimpleEvent += OnSimpleEvent; subscribes to the event.
*/

namespace BasicEventDeclarationAndHandling_01
{
    // Publisher class that declares an event
    public class Publisher
    {
        // Declaring an event using EventHandler delegate
        public event EventHandler SimpleEvent;

        // Method to raise the event
        public void RaiseEvent()
        {
            // Check if there are any subscribers to the event before raising it
            SimpleEvent?.Invoke(this, EventArgs.Empty);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Basic Event Declaration and Handling in C# with Visual Studio\n");

            Publisher publisher = new Publisher();

            // Subscribing to the event using a method
            publisher.SimpleEvent += OnSimpleEvent;

            // Triggering the event
            publisher.RaiseEvent(); // Output: Event triggered!
        }

        // Event handler method
        private static void OnSimpleEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Event triggered!");
        }
    }
}