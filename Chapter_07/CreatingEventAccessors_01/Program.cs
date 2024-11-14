// Program to demonstrate Creating Event Accessors in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Custom Event Accessors: Define custom logic for adding/removing event handlers.
    Fine-Grained Control: Useful for debugging and custom scenarios.
*/

namespace CreatingEventAccessors_01
{
    class CustomEvent
    {
        private EventHandler _myEvent;

        public event EventHandler MyEvent
        {
            add
            {
                _myEvent += value;
                Console.WriteLine("Subscriber added");
            }
            remove
            {
                _myEvent -= value;
                Console.WriteLine("Subscriber removed");
            }
        }

        public void RaiseEvent()
        {
            _myEvent?.Invoke(this, EventArgs.Empty);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Creating Event Accessors in C# with Visual Studio\n");

            CustomEvent customEvent = new CustomEvent();

            EventHandler eventHandler = (sender, e) => Console.WriteLine("Event handled");

            customEvent.MyEvent += eventHandler;
            customEvent.RaiseEvent();
            customEvent.MyEvent -= eventHandler;
        }
    }
}
