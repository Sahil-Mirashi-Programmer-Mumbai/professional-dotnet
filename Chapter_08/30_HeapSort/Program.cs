// Program to demonstrate Heap Sort in C# with Visual Studio
// Programmer: Sahil Mirashi

/* 
 Explanation:
 - Heap sort is a comparison-based sorting technique based on Binary Heap Data Structure.  
 - Heap Sort uses a binary heap data structure to sort an array.
 - It first builds a max heap, then repeatedly extracts the largest element and places it at the end of the array.
 - Time complexity: O(n log n), making it efficient for large datasets.
 - Applications: Suitable for systems with limited memory and can be used in priority queues.
 */

namespace HeapSort
{
    class HeapSortExample
    {
        public static void Heapify(int[] numbers, int lowIndex, int highIndex)
        {
            // Assume the root is the largest
            int largestIndex = lowIndex;

            // Calculate the index of left and right child
            int left = lowIndex * 2 + 1;
            int right = lowIndex * 2 + 2;

            // Check if the left child exists and is greater than the root
            if (left < highIndex && numbers[left] > numbers[largestIndex])
            {
                largestIndex = left;
            }

            // Check if the right child exists and is greater than the largest so far
            if (right < highIndex && numbers[right] > numbers[largestIndex])
            {
                largestIndex = right;
            }

            // If the largest is not the root, swap it with the largest and recursively heapify the affected subtree
            if (largestIndex != lowIndex)
            {
                // Swap the values at 'largest' and 'low'
                Swap(ref numbers[largestIndex], ref numbers[lowIndex]);

                // Recursively heapify the affected subtree
                Heapify(numbers, largestIndex, highIndex);
            }
        }

        public static void HeapSort(int[] numbers, int length)
        {
            // Step 1: Build a max heap
            // Start from the last non-leaf node and heapify each node
            for (int loopCounter = length / 2 - 1; loopCounter >= 0; loopCounter--)
            {
                Heapify(numbers, loopCounter, length);
            }

            // Step 2: Extract elements from the heap one by one
            for (int loopCounter = length - 1; loopCounter > 0; loopCounter--)
            {
                // Move the root (largest value) to the end of the array
                Swap(ref numbers[loopCounter], ref numbers[0]);

                // Reduce the heap size and heapify the root node to restore max heap
                Heapify(numbers, 0, loopCounter);
            }
        }

        // Method to swap two elements in the array
        public static void Swap(ref int firstNumber, ref int secondNumber)
        {
            // Swap the values of 'firstNumber' and 'secondNumber' using a temporary variable
            int temporarySwapVariable = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temporarySwapVariable;
        }


        static void Main(string[] args)
        {
            Console.WriteLine($"Program to demonstrate Heap Sort in C# with Visual Studio\n");

            // Sample array to be sorted
            int[] array = { 63, 27, 42, 68, 72 };

            Console.WriteLine("Original array:");
            Console.WriteLine(string.Join(" ", array));

            // Call the Heap Sort function
            HeapSort(array, array.Length);

            Console.WriteLine("\nSorted array using Heap Sort:");
            Console.WriteLine(string.Join(" ", array));
        }
    }
}