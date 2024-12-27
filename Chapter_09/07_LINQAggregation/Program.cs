/*
Program to demonstrate LINQ Aggregation in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: LINQ methods like Sum, Max, and Count simplify common calculations.
Application: Generating summaries or statistics from datasets.
*/

namespace LINQAggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate LINQ Aggregation in C# with Visual Studio\n");

            // Array of numbers
            int[] numbers = { 5, 10, 15, 20 };

            // Using LINQ for aggregation
            int sum = numbers.Sum();
            int max = numbers.Max();
            int count = numbers.Count();

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Count: {count}");
        }
    }
}