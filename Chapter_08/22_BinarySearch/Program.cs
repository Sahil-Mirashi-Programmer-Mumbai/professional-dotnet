// Program to demonstrate Binary Search in C# with Visual Studio
// Programmer: Sahil Mirashi

/* 
 Explanation:
 - "Binary search" works by repeatedly dividing the search interval in half.
 - It requires a sorted array for efficient searching.
 - Time complexity: O(log n).
 - Applications: Efficient for large datasets when data is sorted (e.g., dictionaries, phone books).
 */

namespace _22_BinarySearch
{
    class Program
    {
        // Binary Search function for a sorted array
        public static int BinarySearch(int[] array_to_search, int target)
        {
            // Define the initial bounds for searching
            int left_index = 0;
            int right_index = array_to_search.Length - 1;

            // Continue searching while there is a range to consider
            while (left_index <= right_index)
            {
                // Calculate the middle index (middle_index-point of the search range)
                int middle_index = (right_index + left_index) / 2;

                // Check if the middle element matches the target
                if (array_to_search[middle_index] == target)
                {
                    return middle_index; // Element found, return its index
                }
                else if (array_to_search[middle_index] < target)
                {
                    // Target is greater than the middle element; adjust left_index bound
                    left_index = middle_index + 1;
                }
                else
                {
                    // Target is less than the middle element; adjust right_index bound
                    right_index = middle_index - 1;
                }
            }

            // Return -1 if the element is not found
            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Binary Search in C# with Visual Studio\n");

            // Example sorted array (Binary Search requires sorted data)
            int[] sortedNumbers = { 1, 3, 5, 7, 9, 11, 13 };
            // Target element to search for
            int target = 7;

            // Call the BinarySearch method and store the result
            int result = BinarySearch(sortedNumbers, target);

            // Check the result and print appropriate output
            if (result != -1)
            {
                Console.WriteLine($"Element {target} found at index {result}.");
            }
            else
            {
                Console.WriteLine($"Element {target} not found in the array.");
            }
        }
    }
}
