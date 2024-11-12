// Program to demonstrate Lambdas with LINQ Queries in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    LINQ Queries: Use lambdas for concise filtering and projection.
    Functional Composition: Where and Select together create powerful query-like logic.
    Readable Pipelines: Simplifies querying collections.
*/

namespace LambdasWithLINQQueries_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Lambdas with LINQ Queries in C# with Visual Studio\n");

            // Sample array of integers
            int[] numbers = { 9, 7, 2, 5, 1, 4 };

            // Using LINQ with a lambda expression to filter and project elements
            // 'Where' filters elements based on a condition; 'Select' projects each element
            var results = numbers.Where(number => number % 2 == 0).Select(number => number * 10);

            // Displaying the results
            Console.WriteLine("Transformed Even Numbers:");
            foreach (int number in results)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
