// Program to demonstrate Expression Trees with Lambdas in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Expression Trees: Represent lambda expressions as data structures for analysis and transformation.
    Inspection: Useful for dynamic query generation.
    Advanced Scenarios: Like LINQ-to-SQL and dynamic logic.
*/

using System.Linq.Expressions;

namespace ExpressionTreesWithLambdas_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Expression Trees with Lambdas in C# with Visual Studio\n");

            // Creating an expression tree from a lambda expression
            Expression<Func<int, int>> expression = number => number + 1;

            // Inspecting the expression tree structure
            Console.WriteLine($"Expression: {expression}"); // Output: number => (number + 1)
            Console.WriteLine($"Body: {expression.Body}");   // Output: (number + 1)
            Console.WriteLine($"Parameter: {expression.Parameters[0]}"); // Output: number
        }
    }
}
