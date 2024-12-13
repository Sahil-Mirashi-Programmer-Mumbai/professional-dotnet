/*
    Program to demonstrate modifying array element with span in C# with Visual Studio
    Programmer: Sahil Mirashi

    Span<T> allows modifying underlying array data efficiently.
    Modifications to a Span<T> reflect directly on the original array since Span<T> provides a view of the memory.
*/

namespace ModifyingArrayElementWithSpan_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate modifying array element with span in C# with Visual Studio\n");

            // Declaring and initializing an array of integers
            int[] numbers = { 7, 9, 4, 1 };

            // Creating a span to represent the first three elements of the array
            Span<int> numberSpan = numbers.AsSpan(0, 4);

            // Modifying the elements through the span
            for (int loopCounter = 0; loopCounter < numberSpan.Length; loopCounter++)
            {
                // Doubling each value
                numberSpan[loopCounter] *= 2;
            }

            // Displaying modified array elements
            Console.WriteLine("Modified Array:");
            foreach (int number in numbers)
            {
                Console.Write($"{number} "); // Output: 14 18 8 2
            }
        }
    }
}
