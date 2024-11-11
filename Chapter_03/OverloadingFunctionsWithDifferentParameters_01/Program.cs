// Program to demonstrate Overloading Functions with Different Parameters in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Method Overloading
    Defining multiple methods with the same name but with different parameter types or numbers of parameters.
*/

namespace OverloadingFunctionsWithDifferentParameters_01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Overloading Functions with Different Parameters in C# with Visual Studio\n");

            // Calling overloaded functions with different parameters.
            Console.WriteLine($"Sum of two integers {AddNumbers(5, 10)}");
            Console.WriteLine($"Sum of two doubles {AddNumbers(5.75, 10.25)}");
        }

        // Function to add two integers.
        static int AddNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        // Overloaded function to add two doubles.
        static double AddNumbers(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

    }
}
