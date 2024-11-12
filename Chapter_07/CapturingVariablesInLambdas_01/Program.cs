// Program to demonstrate Capturing Variables in Lambdas in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Variable Capture: Lambdas capture and reference variables from their defining scope.
    Dynamic Behavior: Changes to captured variables affect lambda logic.
    Use Cases: Useful in closures and callbacks.
*/

namespace CapturingVariablesInLambdas_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Capturing Variables in Lambdas in C# with Visual Studio\n");

            int factor = 10; // Variable to be captured

            // Lambda expression capturing 'factor'
            Func<int, int> multiplyByFactor = number => number * factor;

            // Invoking the lambda
            Console.WriteLine(multiplyByFactor(5)); // Output: 50

            // Changing the captured variable
            factor = 20;
            Console.WriteLine(multiplyByFactor(5)); // Output: 100
        }
    }
}
