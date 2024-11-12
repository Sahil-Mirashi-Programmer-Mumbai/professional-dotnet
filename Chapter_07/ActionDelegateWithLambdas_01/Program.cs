// Program to demonstrate Action Delegate with Lambdas in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Action Delegate
    Action delegate is a predefined generic delegate that can encapsulate a method that performs a task but does not return a value
*/

namespace ActionDelegateWithLambdas_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Action Delegate with Lambdas in C# with Visual Studio\n");

            // Action delegate represents a method that takes a parameter but returns void
            // Use Action<int> delegate with a lambda expression
            Action<int> printSquare = x => Console.WriteLine($"Square: {x * x}");

            // Invoking the action
            printSquare(6); // Output: Square: 36
        }
    }
}
