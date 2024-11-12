// Program to demonstrate Basic Lambda Expression in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Lambda expressions are one of the core features of C# that bring the power of functional programming into a strongly-typed, object-oriented language.
    They allow you to create concise and inline functions that can be used wherever delegate types are expected.

    Lambda Expression: An anonymous function used to create delegates or expression tree types. Syntax: (input-parameters) => expression
    Single Parameter: Parentheses are optional when there is one parameter (n => n * n).
    Simplified Syntax: No return keyword or curly braces are needed for single-line expressions.
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