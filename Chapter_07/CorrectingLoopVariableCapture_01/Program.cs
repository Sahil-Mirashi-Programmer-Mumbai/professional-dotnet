// Program to demonstrate Correcting Loop Variable Capture in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Explanation:
    - By copying 'loopCounter' to 'loopVariable', we ensure each closure captures a unique copy.
    - This demonstrates a correct way to capture loop variables in closures.
*/

namespace CorrectingLoopVariableCapture_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Correcting Loop Variable Capture in C# with Visual Studio\n");

            Action[] actions = new Action[3];

            for (int loopCounter = 0; loopCounter < 3; loopCounter++)
            {
                int loopVariable = loopCounter; // Copy 'loopCounter' to a new variable for correct capture
                actions[loopCounter] = () => Console.WriteLine($"Value of loopCounter: {loopVariable}");
            }

            foreach (var action in actions)
            {
                action(); // Output: Value of loopCounter: 0, Value of loopCounter: 1, Value of loopCounter: 2
            }
        }
    }
}
