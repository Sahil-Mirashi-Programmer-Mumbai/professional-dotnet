// Program to demonstrate Capturing Loop Variables in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Explanation:
    - This demonstrates a common pitfall where loop variables are captured by closures.
    - In this example, the variable 'loopCounter' is shared across all closures, leading to unexpected output.
    - Correcting this requires capturing a copy of the loop variable.
*/

namespace CapturingLoopVariables_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Capturing Loop Variables in C# with Visual Studio\n");

            Action[] actions = new Action[3];

            // Loop variable 'loopCounter' is captured by the closures
            for (int loopCounter = 0; loopCounter < 3; loopCounter++)
            {
                actions[loopCounter] = () => Console.WriteLine($"Value of loopCounter: {loopCounter}");
            }

            foreach (var action in actions)
            {
                action(); // Output: Value of loopCounter: 3 (printed three times)
            }
        }
    }
}
