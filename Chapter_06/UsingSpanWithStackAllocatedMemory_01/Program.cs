// Program to demonstrate using span with stack allocated memory in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Demonstrates using stackalloc with Span < T > for stack - based memory allocation.
    Ideal for scenarios that require high performance without heap allocations.
    Care must be taken since stack memory has limited size compared to the heap.
*/

namespace UsingSpanWithStackAllocatedMemory_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate using span with stack allocated memory in C# with Visual Studio\n");

            // Using stack-allocated memory for performance-critical scenarios
            // Span<T> can point to stack-allocated memory using stackalloc
            Span<int> stackAllocatedSpan = stackalloc int[] { 7, 8, 9, 1 };

            // Displaying stack-allocated elements
            Console.WriteLine("Stack-Allocated Span Elements:");
            foreach (int element in stackAllocatedSpan)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
