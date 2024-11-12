// Program to demonstrate Performance Consideration in Boxing and Unboxing in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    This example shows the performance cost of boxing/unboxing due to heap allocations and type casting.
    In high-performance scenarios, frequent boxing/unboxing should be minimized.
*/

using System.Diagnostics;

namespace PerformanceConsiderationInBoxingAndUnboxing_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Performance Consideration in Boxing and Unboxing in C# with Visual Studio\n");

            // Demonstrating the performance cost of boxing/unboxing
            Stopwatch stopwatch = new Stopwatch();

            int iterations = 10_00_000; // Number of iterations
            int sum = 0;

            stopwatch.Start();
            for (int loop_counter = 0; loop_counter < iterations; loop_counter++)
            {
                // Example of boxing: each iteration boxes the int value into an object
                object boxed = loop_counter; // Boxing occurs here
                sum += (int)boxed; // Unboxing occurs here
            }
            stopwatch.Stop();

            Console.WriteLine($"Total time for boxing/unboxing operations: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
