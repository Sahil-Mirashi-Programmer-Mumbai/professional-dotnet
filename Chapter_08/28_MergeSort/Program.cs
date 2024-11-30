// Program to demonstrate Merge Sort in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace MergeSort
{
    internal class Program
    {
        public static void MergeSort(int[] numbers, int low, int high)
        {
            // Base case: If the subarray contains only one element the array is already sorted
            if (low < high)
            {
                // Calculate the middle index of subarray
                int mid = (low + high) / 2;

                // Recursive case: Recursively sort the left half of the subarray
                MergeSort(numbers, low, mid);

                // Recursive case: Recursively sort the right half of the subarray
                MergeSort(numbers, mid + 1, high);

                // Merge the two sorted subarrays into a single sorted array
                Merge(numbers, low, mid, high);
            }
        }

        public static void Merge(int[] numbers, int low, int mid, int high)
        {
            // Initialize pointers for traversing the left and right subarrays
            int left = low;
            int right = mid + 1;

            // Create a temporary list to store the merged result
            List<int> temp = new List<int>();

            // Compare elements from both the subarrays and merge them in sorted order
            while (left <= mid && right <= high)
            {
                if (numbers[left] < numbers[right])
                {
                    temp.Add(numbers[left]);
                    left++;
                }
                else
                {
                    temp.Add(numbers[right]);
                    right++;
                }
            }

            // Adding remaining elements from left subarray
            while (left <= mid)
            {
                temp.Add(numbers[left]);
                left++;
            }

            // Adding remaining element from right subarray
            while (right <= high)
            {
                temp.Add(numbers[right]);
                right++;
            }

            // Copy the merge elements back to the original array
            for (int i = low; i <= high; i++)
            {
                numbers[i] = temp[i - low];
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Merge Sort in C# with Visual Studio\n");

            // Create a Random object
            Random random = new Random();

            // Define the range
            int startRange = 1;
            int endRange = 100;

            // Define how many random numbers to generate
            int count = 5;

            // Create an array to store random numbers
            int[] numbers = new int[count];

            // Generate random numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(startRange, endRange);
            }

            Console.WriteLine($"Unsorted array: {string.Join(' ', numbers)}");

            MergeSort(numbers, 0, numbers.Length - 1);

            Console.WriteLine($"Sorted array: {string.Join(' ', numbers)}");
        }
    }
}