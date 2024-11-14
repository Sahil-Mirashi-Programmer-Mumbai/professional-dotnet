// Program to demonstrate Events with Multiple Subscribers in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Multiple Subscribers: Multiple methods can handle the same event.
    Invocation List: Events maintain a list of subscribers.
*/

namespace EventsWithMultipleSubscribers_01
{
    public class Publisher
    {
        public event EventHandler MultiEvent;

        public void RaiseEvent()
        {
            MultiEvent?.Invoke(this, EventArgs.Empty);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Events with Multiple Subscribers in C# with Visual Studio\n");

            Publisher publisher = new Publisher();

            // Multiple subscribers
            publisher.MultiEvent += Subscriber1;
            publisher.MultiEvent += Subscriber2;

            // Triggering the event
            publisher.RaiseEvent();
            // Output:
            // Subscriber 1 received event
            // Subscriber 2 received event
        }

        private static void Subscriber1(object sender, EventArgs e)
        {
            Console.WriteLine("Subscriber 1 received event");
        }

        private static void Subscriber2(object sender, EventArgs e)
        {
            Console.WriteLine("Subscriber 2 received event");
        }
    }
}
