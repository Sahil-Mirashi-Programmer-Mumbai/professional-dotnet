// Program to demonstrate Selection Sort in C# with Visual Studio
// Programmer: Sahil Mirashi

/* 
 Explanation:
 - Selection Sort divides the array into a sorted and an unsorted part.
 - It repeatedly selects the minimum element from the unsorted part and moves it to the sorted part.
 - Time complexity: O(lengthOfArray^2). Not suitable for large datasets.
 - Applications: Useful when memory writes are a concern.
 */

namespace SelectionSort
{
    class SelectionSortExample
    {
        // Method to perform Selection Sort
        static void SelectionSort(int[] array)
        {
            int lengthOfArray = array.Length; // Length of the array

            // Traverse the array
            for (int outerLoopCounter = 0; outerLoopCounter < lengthOfArray - 1; outerLoopCounter++)
            {
                // Find the minimum element in the unsorted part of the array
                int minIndex = outerLoopCounter;
                for (int innerLoopCounter = outerLoopCounter + 1; innerLoopCounter < lengthOfArray; innerLoopCounter++)
                {
                    if (array[innerLoopCounter] < array[minIndex])
                    {
                        minIndex = innerLoopCounter;
                    }
                }

                // Swap the found minimum element with the first element of the unsorted part
                int temp = array[minIndex];
                array[minIndex] = array[outerLoopCounter];
                array[outerLoopCounter] = temp;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Selection Sort in C# with Visual Studio\n");

            // Sample array to be sorted
            int[] array = { 29, 10, 14, 37, 13 };

            Console.WriteLine("Original array:");
            Console.WriteLine(string.Join(" ", array));

            // Call the Selection Sort function
            SelectionSort(array);

            Console.WriteLine("\nSorted array using Selection Sort:");
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
