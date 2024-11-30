// Program to demonstrate Quick Sort in C# with Visual Studio
// Programmer: Sahil Mirashi

/* 
 Explanation:
 - Quick Sort is a highly efficient sorting algorithm based on the divide-and-conquer approach.
 - It partitions the array into smaller sub-arrays around a pivot and recursively sorts the sub-arrays.
 - Time complexity: O(n log n) on average, but O(n^2) in the worst case (rare).
 - Applications: Frequently used for sorting large datasets in many programming libraries.
 */

namespace QuickSort
{
    class QuickSortExample
    {
        public static void QuickSort(int[] numbers, int low, int high)
        {
            // Base case: If the subarray contains only one element the array is already sorted
            if (low < high)
            {
                // Partition the array and get the index of the pivot element
                int partitionIndex = Partition(numbers, low, high);

                // Recursive case: Recursively sort elements on the left of the pivot
                QuickSort(numbers, low, partitionIndex - 1);

                // Recursive case: Recursively sort elements on the right of the pivot
                QuickSort(numbers, partitionIndex + 1, high);
            }
        }

        // Method to partition the array and determine the pivot's correct position
        public static int Partition(int[] numbers, int lowIndex, int highIndex)
        {
            // Set the pivot element as the first element of the current subarray
            int pivotValue = numbers[lowIndex];

            // Initialize left and right pointers
            int leftMarker = lowIndex;
            int rightMarker = highIndex;

            // Loop until the left and right pointers cross
            while (leftMarker < rightMarker)
            {
                // Move the left pointer to the right while numbers are less than or equal to the pivot
                while (numbers[leftMarker] <= pivotValue && leftMarker < highIndex)
                {
                    leftMarker++;
                }

                // Move the right pointer to the left while numbers are greater than the pivot
                while (numbers[rightMarker] > pivotValue && rightMarker > lowIndex)
                {
                    rightMarker--;
                }

                // If the left pointer is still less than the right pointer, swap the elements
                if (leftMarker < rightMarker)
                {
                    Swap(ref numbers[leftMarker], ref numbers[rightMarker]);
                }
            }

            // Swap the pivot element with the element at the right pointer
            // Since rightMarker is checking for values less than pivot we are swapping lowIndex with rightMarker
            Swap(ref numbers[lowIndex], ref numbers[rightMarker]);

            // Return the final position of the pivot
            return rightMarker;
        }

        // Method to swap two elements in the array
        public static void Swap(ref int firstNumber, ref int secondNumber)
        {
            // Store the value of the first number in a temporary variable
            int temporarySwapVariable = firstNumber;

            // Assign the value of the second number to the first number
            firstNumber = secondNumber;

            // Assign the value of the temporary variable to the second number
            secondNumber = temporarySwapVariable;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Quick Sort in C# with Visual Studio\n");

            // Define an array of integers to be sorted
            int[] numbers = { 7, 9, 5, 2, 4 };

            Console.WriteLine($"Unsorted array: {string.Join(' ', numbers)}");

            // Perform QuickSort on the array
            QuickSort(numbers, 0, numbers.Length - 1);

            Console.WriteLine($"Sorted array: {string.Join(' ', numbers)}");
        }
    }
}