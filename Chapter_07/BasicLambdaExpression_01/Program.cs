// Program to demonstrate Basic Lambda Expression in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Lambda Expression
    A lambda expression is an inline, anonymous function that can contain expressions or statements.
    
    Syntax
    (parameters) => expression
*/

namespace BasicLambdaExpression_01
{
    // Defining a delegate type that takes an integer and returns an integer
    delegate int Operation(int number);

    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Program to demonstrate Basic Lambda Expression in C# with Visual Studio\n");

            // Using a lambda expression to define a function that squares a number
            // Syntax: (parameters) => expression or block
            // Here, 'n' is the parameter, and 'n * n' is the expression
            Operation square = number => number * number;

            // Calling the lambda expression through the delegate
            int result = square(5);

            Console.WriteLine($"Square of 5: {result}"); // Output: Square of 5: 25
        }
    }
}