// Program to demonstrate Basic Function with Parameters and Return Type in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace BasicFunctionWithParametersAndReturnType_01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Basic Function with Parameters and Return Type in C# with Visual Studio\n");

            // Calling the AddNumbers function and storing the result.
            int result = AddNumbers(10, 5);

            // Display the result.
            Console.WriteLine($"Sum: {result}"); // Output: Sum: 15
        }

        /// <summary>
        /// Add two numbers and returns the sum
        /// </summary>
        /// <param name="firstNumber">First number</param>
        /// <param name="secondNumber">Second number</param>
        /// <returns>Returns the sum of two numbers</returns>
        static int AddNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
