// Program to demonstrate working with large arrays efficiently in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Demonstrates using Span<T> for large array manipulations without creating new arrays.
    Useful for optimizing memory use and avoiding performance issues due to excessive allocations.
*/

namespace WorkingWithLargeArraysEfficiently_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate working with large arrays efficiently in C# with Visual Studio\n");

            // Creating a large array of integers
            int[] largeArray = new int[10_00_000];

            for (int loopCounter = 0; loopCounter < largeArray.Length; loopCounter++)
            {
                largeArray[loopCounter] = loopCounter;
            }

            // Creating a Span from a segment of the large array
            Span<int> spanSegment = largeArray.AsSpan(100, 1000);

            // Modifying elements within the span
            for (int loopCounter = 0; loopCounter < spanSegment.Length; loopCounter++)
            {
                spanSegment[loopCounter] *= 2; // Multiply each element by 2
            }

            // Displaying modified segment values
            foreach (int element in spanSegment)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
