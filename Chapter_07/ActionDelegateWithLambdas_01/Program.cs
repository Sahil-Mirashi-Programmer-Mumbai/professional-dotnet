// Program to demonstrate Action Delegate with Lambdas in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Action Delegate: Represents a void-returning method with zero or more parameters.
    Lambdas as Actions: Useful for callbacks or operations with no return value.
    Increased Flexibility: Simplifies inline logic.
*/

namespace ActionDelegateWithLambdas_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Action Delegate with Lambdas in C# with Visual Studio\n");

            // Action delegate represents a method that takes a parameter but returns void
            // Here, we use an Action<int> delegate with a lambda expression
            Action<int> printSquare = x => Console.WriteLine($"Square: {x * x}");

            // Invoking the action
            printSquare(6); // Output: Square: 36
        }
    }
}
