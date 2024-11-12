// Program to demonstrate anonymous methods with delegates in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Anonymous Methods: Defined using the delegate keyword without a separate named method.
    Encapsulation: Useful for defining inline methods, often with minimal logic.
*/

namespace AnonymousMethodsWithDelegates_01
{
    // Delegate matching methods with a single string parameter and void return type
    public delegate void Display(string message);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate anonymous methods with delegates in C# with Visual Studio\n");

            // Defining anonymous method using a delegate
            Display display = delegate (string message)
            {
                Console.WriteLine($"Message: {message}");
            };

            // Invoking the delegate
            display("Welcome"); // Output: Message: Welcome
        }
    }
}
