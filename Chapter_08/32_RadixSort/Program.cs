/* Explanation:
 * - Radix Sort is a non-comparative sorting algorithm that sorts numbers digit by digit from the least significant digit to the most significant.
 * - It uses Counting Sort as a subroutine to sort each digit.
 * - Time complexity: O(n * k), where n is the number of elements and k is the number of digits.
 * - Applications: Effective for sorting large sets of data where elements have a fixed number of digits (e.g., integers, dates).
 */

namespace SortingAlgorithmsExample
{
    class RadixSortExample
    {
        // Method to perform Radix Sort
        static void CountingSortForRadix(int[] array, int exp)
        {
            int n = array.Length; // Get the length of the array, which tells how many elements are there in the array
            int[] output = new int[n]; // Create an output array to store sorted elements for the current digit
            int[] count = new int[10]; // Create a count array of size 10 (for digits 0-9) to store frequency of digits

            // Count occurrences of digits at the current place value (unit, tens, hundreds, etc.)
            for (int i = 0; i < n; i++)
                count[(array[i] / exp) % 10]++; // Update the count array with occurrences of each digit (based on 'exp')

            // Update count[] to contain actual positions of digits in output[]
            for (int i = 1; i < 10; i++)
                count[i] += count[i - 1]; // Modify the count array so each index contains the cumulative count of elements up to that digit

            // Build the output array by placing elements in their correct position based on the current digit
            for (int i = n - 1; i >= 0; i--) // Traverse the array backwards to maintain stable sorting (important for radix sort)
            {
                output[count[(array[i] / exp) % 10] - 1] = array[i]; // Place the element in the correct position in the output array
                count[(array[i] / exp) % 10]--; // Decrease the count for the current digit
            }

            // Copy the output array to the original array[], so that array[] now contains sorted numbers for the current digit
            for (int i = 0; i < n; i++)
                array[i] = output[i]; // Update the original array with sorted elements
        }

        static void RadixSort(int[] array)
        {
            int max = array[0]; // Initialize 'max' with the first element of the array, it will be used to determine the number of digits
            foreach (int num in array) // Iterate through each number in the array
                if (num > max) max = num; // Find the maximum number in the array to determine the number of digits it has

            // Perform Counting Sort for every digit (from least significant to most significant)
            for (int exp = 1; max / exp > 0; exp *= 10) // Iterate through each place value (1's, 10's, 100's, etc.)
                CountingSortForRadix(array, exp); // Call the CountingSortForRadix function for each place value, which sorts the array by that digit
        }

        static void Main(string[] args)
        {
            // Sample array to be sorted
            int[] array = { 170, 45, 75, 90, 802, 24, 2, 66 };

            Console.WriteLine("Original array:");
            Console.WriteLine(string.Join(" ", array));

            // Call the Radix Sort function
            RadixSort(array);

            Console.WriteLine("\nSorted array using Radix Sort:");
            Console.WriteLine(string.Join(" ", array));
        }
    }
}