// Program to demonstrate basic delegate declaration and invocation in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Definition: A delegate is defined with a method signature it can encapsulate.
    Usage: Here, the PrintMessage delegate type can encapsulate methods with a matching signature (void return type and one string parameter).
    Instantiation and Invocation: printDelegate references PrintToConsole, and calling the delegate (printDelegate("...")) calls the method..
*/

namespace BasicDelegateDeclarationAndInvocation_01
{
    // Step 1: Define a delegate
    // Delegate is type that defines the method signature
    public delegate void PrintMessage(string message);

    internal class Program
    {
        // Method matching the delegate signature
        static void PrintToConsole(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate basic delegate declaration and invocation in C# with Visual Studio\n");

            // Step 2: Instantiate a delegate
            // Delegate printMessage points to PrintToConsole method
            PrintMessage printMessage = new PrintMessage(PrintToConsole);

            // Step 3: Invoke the delegate
            // When a delegate is invoked it calls the method it points to
            printMessage("Hello Delegate"); // Output: Hello Delegate
        }
    }
}
