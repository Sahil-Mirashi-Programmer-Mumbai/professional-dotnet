// Program to demonstrate Using Lambdas with List Filtering in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Lambda Expressions as Arguments: Used with methods like FindAll to filter collections.
    Predicate Delegate: Lambdas can replace predicates for concise, readable code.
    Functional Programming: Simplifies collection manipulation using built-in functions.
*/

namespace UsingLambdasWithListFiltering_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Using Lambdas with List Filtering in C# with Visual Studio\n");

            // Initialize a list of integers
            List<int> numbers = new List<int> { 9, 1, 7, 4, 2};

            // Using a lambda expression with the List's FindAll method to filter even numbers
            // Predicate<int> is a delegate that takes an int and returns a bool
            List<int> evenNumbers = numbers.FindAll(number => number % 2 == 0);

            // Displaying the result
            Console.Write("Even Numbers: ");
            evenNumbers.ForEach(number => Console.Write($"{number} ")); // Output: Even Numbers: 4 2
        }
    }
}
