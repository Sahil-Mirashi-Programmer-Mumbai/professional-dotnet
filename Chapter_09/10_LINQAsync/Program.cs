/*
Program to demonstrate LINQ Async in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: LINQ can be applied to asynchronous streams, useful for real-time data filtering.
Application: Handling live data streams efficiently.
*/

namespace LINQAsyncDemo
{
    class Program
    {
        static async IAsyncEnumerable<int> GetNumbersAsync()
        {
            for (int i = 1; i <= 10; i++)
            {
                await Task.Delay(500); // Simulating asynchronous data fetching
                yield return i;
            }
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate LINQ Async in C# with Visual Studio\n");

            // Filtering even numbers from asynchronous stream
            await foreach (var num in GetNumbersAsync().WhereAwait(async num =>
            {
                await Task.Yield(); // Simulating async condition
                return num % 2 == 0;
            }))
            {
                Console.WriteLine($"Even Number: {num}");
            }

            // Explanation:
            // - LINQ can be applied to asynchronous streams using System.Linq.Async extensions.
            // Application: Handling real-time data streams asynchronously.
        }
    }
}
