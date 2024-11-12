// Program to demonstrate Lambdas as Event Handlers in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Event Subscription: Lambdas simplify event handling with inline logic.
    Concise Syntax: Reduces boilerplate code for event handlers.
    Flexibility: Direct inline definitions.
*/

namespace LambdasAsEventHandlers_01
{
    class Button
    {
        // Defining an event using EventHandler delegate
        public event EventHandler Click;

        // Method to simulate button click
        public void OnClick()
        {
            Click?.Invoke(this, EventArgs.Empty);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Lambdas as Event Handlers in C# with Visual Studio\n");

            Button button = new Button();

            // Subscribing to the event using a lambda expression
            button.Click += (sender, e) => Console.WriteLine("Button clicked!");

            // Simulating a button click
            button.OnClick(); // Output: Button clicked!
        }
    }
}
