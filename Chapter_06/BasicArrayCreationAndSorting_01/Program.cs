// Program to demonstrate Basic Array Creation and Sorting in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Demonstrates creating and sorting an array using Array.Sort().
    Array.Sort() is used to sort elements in ascending order.
    Sorting is a common operation used in data processing, enabling easier searching and comparison of elements.
*/

namespace BasicArrayCreationAndSorting_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Basic Array Creation and Sorting in C# with Visual Studio\n");

            // Creating an array of integers
            int[] numbers = { 7, 9, 5, 4, 1 };

            Console.WriteLine("Unsorted Array");
            // Printing original array
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }

            // Sorting the array using the Array.Sort method
            // Array.Sort sorts the elements of the array in ascending order
            Array.Sort(numbers);

            // Printing the sorted array
            Console.WriteLine("\nSorted Array");
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
