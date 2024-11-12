// Program to demonstrate Multi Parameter Lambda Expression in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Multiple Parameters: Parentheses are required when specifying multiple parameters ((a, b) => a + b).
    Concise Functions: Lambdas are ideal for concise mathematical or functional logic.
    Elimination of Boilerplate: No need to define separate named methods.
*/

namespace MultiParameterLambdaExpression_01
{
    // Define a delegate that takes two integers and returns an integer
    delegate int MathOperation(int firstNumber, int secondNumber);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Multi Parameter Lambda Expression in C# with Visual Studio\n");

            // Lambda expression with multiple parameters
            // Syntax: (parameters) => expression
            MathOperation add = (int firstNumber, int secondNumber) => firstNumber + secondNumber;

            // Using the lambda to add two numbers
            int addResult = add(7, 2);
            Console.WriteLine($"Add: {addResult}"); // Output: Add: 9
        }
    }
}
