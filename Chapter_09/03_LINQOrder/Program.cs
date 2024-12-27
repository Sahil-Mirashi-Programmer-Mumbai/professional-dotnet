/*
Program to demonstrate LINQ Order in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: "orderby num" sorts the list.
Application: Useful for displaying sorted data in UI or reports.
*/

namespace LINQOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate LINQ Order in C# with Visual Studio\n");

            // List of integers
            List<int> numbers = new List<int> { 9, 3, 7, 1, 5 };

            // Sorting numbers in ascending order using LINQ
            var sortedNumbers = from num in numbers
                                orderby num descending
                                select num;

            // Displaying sorted numbers
            Console.WriteLine("Sorted Numbers:");
            foreach (var number in sortedNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}