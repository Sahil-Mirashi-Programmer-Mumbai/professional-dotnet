// Program to demonstrate delegates as method parameters in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Delegates as Parameters: This enables callback functionality where the caller specifies which method to execute.
    Flexible Method Invocation: The Calculate method can perform any operation defined by the passed delegate.
*/

namespace DelegatesAsMethodParameters_01
{
    // Delegate that takes two integers and returns an integer
    public delegate int Operation(int firstNumber, int secondNumber);

    internal class Program
    {
        // Method performing operation using the delegate
        public static int Calculate(int firstNumber, int secondNumber, Operation operation)
        {
            return operation(firstNumber, secondNumber);
        }

        // Methods matching the delegate signature
        public static int Add(int firstNumber, int secondNumber) => firstNumber + secondNumber;
        public static int Multiply(int firstNumber, int secondNumber) => firstNumber * secondNumber;

        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate delegates as method parameters in C# with Visual Studio\n");

            // Passing Add method as delegate parameter
            int sum = Calculate(5, 7, Add);
            Console.WriteLine($"Sum: {sum}"); // Output: Sum: 12

            // Passing Multiply method as delegate parameter
            int product = Calculate(5, 7, Multiply);
            Console.WriteLine($"Product: {product}"); // Output: Product: 35
        }
    }
}
