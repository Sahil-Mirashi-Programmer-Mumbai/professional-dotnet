// Program to demonstrate basic slicing with Span in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Span<T> provides a memory-efficient way to represent and manipulate a segment of an array without copying data.
    AsSpan() creates a Span<T> from an existing array.
    Slice() allows accessing sub-portions of the array using the Span<T> API.
*/

namespace BasicSlicingWithSpan_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate basic slicing with Span in C# with Visual Studio\n");

            // Declaring and initializing an array of integers
            int[] numbers = { 10, 20, 30, 40, 50 };

            // Creating a Span from the original array
            // Span<int> is a memory-efficient representation of the array segment
            Span<int> numberSpan = numbers.AsSpan();

            // Slicing the span to select the middle elements (20, 30)
            Span<int> middleSpan = numberSpan.Slice(1, 2);

            // Displaying elements of the sliced span
            Console.WriteLine("Sliced Span:");
            foreach (int number in middleSpan)
            {
                Console.Write($"{number} "); // Output: 20, 30
            }
        }
    }
}
