// Program to demonstrate Linear Search in C# with Visual Studio
// Programmer: Sahil Mirashi

/* 
 Explanation:
 - A "linear search" is a basic searching algorithm where we check every element in a list one by one.
 - This method works well for small datasets or unsorted arrays.
 - Time complexity: O(n) (where 'n' is the number of elements in the array).
 - Application: Used when the data is unsorted or in simple searches.
 */

namespace _21_LinearSearch
{
    class Program
    {
        /// <summary>
        /// Linear Search function to find an element in an array
        /// </summary>
        /// <param name="array_to_search"></param>
        /// <param name="target"></param>
        /// <returns>index</returns>
        public static int LinearSearch(int[] array_to_search, int target)
        {
            // Loop through the entire array
            for (int loopCounter = 0; loopCounter < array_to_search.Length; loopCounter++)
            {
                // Check if the current element matches the target
                if (array_to_search[loopCounter] == target)
                {
                    // If a match is found, return the index of the element
                    return loopCounter;
                }
            }
            // If no match is found, return -1 to indicate "not found"
            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Linear Search in C# with Visual Studio\n");

            // Example array to search in
            int[] numbers = { 5, 3, 8, 4, 1, 9 };
            // Target element to search for
            int target = 4;

            // Call the LinearSearch method and store the result
            int result = LinearSearch(numbers, target);

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
