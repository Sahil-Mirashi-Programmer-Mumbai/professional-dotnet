// Program to demonstrate Bubble Sort in C# with Visual Studio
// Programmer: Sahil Mirashi

/* 
 Explanation:
 - Bubble Sort is a simple sorting algorithm that repeatedly compares adjacent elements
   and swaps them if they are in the wrong order.
 - The process continues until the array is completely sorted.
 - Time complexity: O(lengthOfArray^2) for worst and average cases, making it inefficient for large datasets.
 - Applications: Suitable for small data sets or teaching sorting basics.
 */

namespace BubbleSort
{
    class BubbleSortExample
    {
        // Method to perform Bubble Sort
        static void BubbleSort(int[] array)
        {
            int lengthOfArray = array.Length; // Length of the array

            // Outer loop for traversing the array multiple times
            for (int passCounter = 0; passCounter < lengthOfArray - 1; passCounter++)
            {
                // Inner loop for comparing adjacent elements
                for (int loopCounter = 0; loopCounter < lengthOfArray - passCounter - 1; loopCounter++)
                {
                    // If the current element is greater than the next element, swap them
                    if (array[loopCounter] > array[loopCounter + 1])
                    {
                        int temp = array[loopCounter];
                        array[loopCounter] = array[loopCounter + 1];
                        array[loopCounter + 1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Bubble Sort in C# with Visual Studio\n");

            // Sample array to be sorted
            int[] array = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Original array:");
            Console.WriteLine(string.Join(" ", array));

            // Call the Bubble Sort function
            BubbleSort(array);

            Console.WriteLine("\nSorted array using Bubble Sort:");
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
