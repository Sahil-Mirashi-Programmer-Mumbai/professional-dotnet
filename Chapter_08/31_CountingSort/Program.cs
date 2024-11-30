/* 
Program to demonstrate Counting Sort in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation:
- Counting Sort works by counting the frequency of each element and then using this information to place each element at its correct position.
- It is efficient when the range of input values is not significantly larger than the number of elements.
- Time complexity: O(n + k), where n is the number of elements and k is the range of the input.
- Applications: Ideal for sorting integers or other discrete values (e.g., grades, ages).
*/

namespace SortingAlgorithmsExample
{
    class CountingSortExample
    {
        // Method to perform Counting Sort
        static void CountingSort(int[] array)
        {
            int lengthOfArray = array.Length;

            // Find the maximum element in the array to determine the range
            int maxValue = array[0];
            for (int loopCounter = 1; loopCounter < lengthOfArray; loopCounter++)
            {
                if (array[loopCounter] > maxValue)
                {
                    maxValue = array[loopCounter];
                }
            }

            // Create a count array and initialize it to 0
            int[] countArray = new int[maxValue + 1];
            for (int i = 0; i < lengthOfArray; i++)
            {
                countArray[array[i]]++;
            }

            Console.WriteLine();
            Console.WriteLine("Count array:");
            Console.WriteLine(string.Join(" ", countArray));

            // Rebuild the array using the count array
            int index = 0;
            for (int i = 0; i <= maxValue; i++)
            {
                while (countArray[i] > 0)
                {
                    array[index] = i;
                    index++;
                    countArray[i]--;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Counting Sort in C# with Visual Studio\n");

            // Sample array to be sorted
            int[] array = { 2, 2, 3, 1, 2, 5, 1 };

            Console.WriteLine("Original array:");
            Console.WriteLine(string.Join(" ", array));

            // Call the Counting Sort function
            CountingSort(array);

            Console.WriteLine("\nSorted array using Counting Sort:");
            Console.WriteLine(string.Join(" ", array));
        }
    }
}