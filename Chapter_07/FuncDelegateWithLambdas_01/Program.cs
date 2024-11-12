// Program to demonstrate Func Delegate with Lambdas in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Func Delegate: Encapsulates a method that returns a value.
    Built-In Delegates: Simplifies defining simple or complex logic without custom delegates.
    Flexible and Concise: Easily defined with lambdas.
*/

namespace FuncDelegateWithLambdas_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Func Delegate with Lambdas in C# with Visual Studio\n");

            // Func delegate returns a value (int here), with optional parameters
            // Here, Func<int, int, int> represents a function taking two ints and returning an int
            Func<int, int, int> multiply = (firstNumber, secondNumber) => firstNumber * secondNumber;

            // Using Func delegate
            int product = multiply(4, 5);
            Console.WriteLine($"Product: {product}"); // Output: Product: 20
        }
    }
}
