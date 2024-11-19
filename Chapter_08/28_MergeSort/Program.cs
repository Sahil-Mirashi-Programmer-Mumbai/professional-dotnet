// Program to demonstrate Merge Sort in C# with Visual Studio
// Programmer: Sahil Mirashi

/* 
 Explanation:
 - Merge Sort is a divide-and-conquer algorithm that divides the array into halves,
   sorts each half recursively, and then merges them back together.
 - Time complexity: O(n log n), making it efficient for large datasets.
 - Applications: Suitable for sorting linked lists and external sorting.
 */

namespace _28_MergeSort
{
    class MergeSortExample
    {
        public static void MergeSort(int[] numbers, int lowerIndex, int higherIndex)
        {
            if (lowerIndex == higherIndex)
            {
                return;
            }

            int middleIndex = (lowerIndex + higherIndex) / 2;

            MergeSort(numbers, lowerIndex, middleIndex);
            MergeSort(numbers, middleIndex + 1, higherIndex);
            Merge(numbers, lowerIndex, middleIndex, higherIndex);
        }

        public static void Merge(int[] numbers, int lowerIndex, int middleIndex, int higherIndex)
        {
            int leftIndex = lowerIndex; ;
            int rightIndex = middleIndex + 1;
            List<int> temp = new List<int>();

            while (leftIndex <= middleIndex && rightIndex <= higherIndex)
            {
                if (numbers[leftIndex] <= numbers[rightIndex])
                {
                    temp.Add(numbers[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    temp.Add(numbers[rightIndex]);
                    rightIndex++;
                }
            }

            while (leftIndex <= middleIndex)
            {
                temp.Add(numbers[leftIndex]);
                leftIndex++;
            }

            while (rightIndex <= higherIndex)
            {
                temp.Add(numbers[rightIndex]);
                rightIndex++;
            }

            for (int i = lowerIndex; i <= higherIndex; i++)
            {
                numbers[i] = temp[i - lowerIndex];
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = { 82, 19, 47, 91, 64, 73, 15, 28 };

            Console.WriteLine($"Unsorted: {string.Join(" ", numbers)}");

            MergeSort(numbers, 0, numbers.Length - 1);

            Console.WriteLine($"Sorted: {string.Join(" ", numbers)}");
        }
    }
}
