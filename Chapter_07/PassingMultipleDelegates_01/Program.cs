// Program to demonstrate Passing Multiple Delegates in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Passing Multiple Delegates: Useful for batch processing.
    Variadic Arguments: params allows passing a flexible number of delegates.
*/

namespace PassingMultipleDelegates_01
{
    public delegate int MathOperation(int firstNumber, int secondNumber);

    class Program
    {
        // Method accepting multiple delegates for various operations
        public static void ExecuteOperation(int firstNumber, int secondNumber, params MathOperation[] operations)
        {
            foreach(MathOperation operation in operations)
            {
                Console.WriteLine($"Result: {operation(firstNumber, secondNumber)}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Passing Multiple Delegates in C# with Visual Studio\n");

            MathOperation add = (int firstNumber, int secondNumber) => firstNumber + secondNumber;
            MathOperation subtract = (int firstNumber, int secondNumber) => firstNumber - secondNumber;

            // Passing multiple operations to the method
            ExecuteOperation(97, 12, add, subtract); // Output: Result: 109 Result: 85
        }
    }
}
