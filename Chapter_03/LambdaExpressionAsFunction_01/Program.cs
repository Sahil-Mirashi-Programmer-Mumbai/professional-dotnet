// Program to demonstrate Lambda Expression as Function in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace LambdaExpressionAsFunction_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Lambda Expression as Function in C# with Visual Studio\n");

            // Declares a delegate `multiply` that takes two integers and returns an integer.
            // `Func<int, int, int>` specifies a function delegate with two `int` inputs and an `int` return type.
            Func<int, int, int> multiply = (firstNumber, secondNumber) => firstNumber * secondNumber;

            Console.WriteLine($"Product: {multiply(10, 7)}"); // Product: 70

        }
    }
}
