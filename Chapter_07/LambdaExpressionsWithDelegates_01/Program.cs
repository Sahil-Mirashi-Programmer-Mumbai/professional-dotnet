// Program to demonstrate lambda expressions with delegates in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Lambda Expressions: Shorter syntax for defining methods inline with delegates.
    Functional Programming Style: Improves code readability and maintainability.
*/

namespace LambdaExpressionsWithDelegates_01
{
    // Delegate that takes two integers and returns an integer
    public delegate int Operation(int firstNumber, int secondNumber);

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate lambda expressions with delegates in C# with Visual Studio\n");

            // Defining lambda expression for addition
            Operation add = (firstNumber, secondNumber) => firstNumber + secondNumber;

            // Defining lambda expression for subtraction
            Operation subtract = (firstNumber, secondNumber) => firstNumber - secondNumber;

            // Using the lambda expression
            Console.WriteLine($"Add: {add(15, 7)}"); // Output: Add: 22
            Console.WriteLine($"Subtract: {subtract(35, 7)}"); // Output: Subtract: 28
        }
    }
}
