// Program to demonstrate Closures Capturing Variables in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Explanation:
    - Closures can capture and modify variables defined in their containing scope.
    - Here, 'counter' is captured by the lambda expression and retains its value across calls.
    - This demonstrates state maintenance using closures.
*/

namespace ClosuresCapturingVariables_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Closures Capturing Variables in C# with Visual Studio\n");

            int counter = 0; // This variable is captured by the closure
            Action incrementCounter = () =>
            {
                // Closure captures the variable 'counter' and modifies it
                counter++;
                Console.WriteLine($"Counter value: {counter}");
            };

            incrementCounter(); // Output: Counter value: 1
            incrementCounter(); // Output: Counter value: 2
        }
    }
}