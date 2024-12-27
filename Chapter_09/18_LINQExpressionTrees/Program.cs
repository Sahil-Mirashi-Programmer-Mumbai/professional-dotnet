/*
Program to demonstrate LINQ Expression Trees in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: Expression trees represent code as data structures, enabling dynamic query generation.
Application: Used in ORMs, compilers, or dynamic query generation.
*/

using System.Linq.Expressions;

namespace LINQExpressionTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate LINQ Expression Trees in C# with Visual Studio\n");

            // Defining an expression tree
            Expression<Func<int, int>> square = num => num * num;

            // Compiling the expression tree into a usable delegate
            var squareFunction = square.Compile();

            // Using the compiled delegate
            Console.WriteLine($"Square of 4: {squareFunction(4)}");
        }
    }
}