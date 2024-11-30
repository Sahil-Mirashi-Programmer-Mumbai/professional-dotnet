// Program to demonstrate Insertion Sort in C# with Visual Studio
// Programmer: Sahil Mirashi

/* 
 Explanation:
 - Insertion Sort works similarly to the way we sort playing cards in our hands.
 - It builds the sorted array one element at a time by inserting each element
   into its correct position in the sorted part of the array.
 - Time complexity: O(length^2) in the worst case and O(length) in the best case when the array is nearly sorted.
 - Applications: Good for small or nearly sorted datasets.
 */

namespace InsertionSort
{
    class InsertionSortExample
    {
        // Method to perform Insertion Sort
        static void InsertionSort(int[] array)
        {
            int lengthOfArray = array.Length;

            // Iterate through each element starting from the second element
            for (int outerLoopCounter = 1; outerLoopCounter < lengthOfArray; outerLoopCounter++)
            {
                int temp = array[outerLoopCounter]; // Element to be inserted into the sorted part
                int innerLoopCounter = outerLoopCounter - 1;

                // Move elements of array[0..outerLoopCounter-1] that are greater than temp one position ahead
                while (innerLoopCounter >= 0 && array[innerLoopCounter] > temp)
                {
                    array[innerLoopCounter + 1] = array[innerLoopCounter];
                    innerLoopCounter--;
                }
                array[innerLoopCounter + 1] = temp; // Insert temp at the correct position
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Insertion Sort in C# with Visual Studio\n");

            // Sample array to be sorted
            int[] array = { 12, 11, 13, 5, 6 };

            Console.WriteLine("Original array:");
            Console.WriteLine(string.Join(" ", array));

            // Call the Insertion Sort function
            InsertionSort(array);

            Console.WriteLine("\nSorted array using Insertion Sort:");
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
