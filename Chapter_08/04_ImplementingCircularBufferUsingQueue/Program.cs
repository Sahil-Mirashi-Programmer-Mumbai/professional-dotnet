// Program to demonstrate implementing Circular Buffer using Queue in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    This example uses a queue to implement a simple circular buffer with a fixed size.
    Circular buffers are common in buffering data streams, handling data in I/O devices, etc.
    Demonstrates how to maintain a buffer's size while allowing new data to overwrite the oldest data.
*/

namespace _04_ImplementingCircularBufferUsingQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate implementing Circular Buffer using Queue in C# with Visual Studio\n");

            int bufferSize = 3;
            Queue<int> circularBuffer = new Queue<int>();

            // Adding elements to the circular buffer
            for (int i = 1; i <= 5; i++)
            {
                if (circularBuffer.Count >= bufferSize)
                {
                    // Remove the oldest element if the buffer is full
                    int removed = circularBuffer.Dequeue();
                    Console.WriteLine($"Buffer full. Removed oldest item: {removed}");
                }
                // Add new element
                circularBuffer.Enqueue(i);
                Console.WriteLine($"Added: {i}");
            }

            // Displaying final buffer contents
            Console.WriteLine("\nFinal Buffer State:");
            foreach (int item in circularBuffer)
            {
                Console.WriteLine(item);
            }
        }
    }
}
