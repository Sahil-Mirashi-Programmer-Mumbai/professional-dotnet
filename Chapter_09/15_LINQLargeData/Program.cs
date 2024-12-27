/*
Program to demonstrate LINQ Large Data in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: LINQ efficiently handles large data streams without materializing them in memory.
Application: Processing big data or logs with minimal memory footprint.
*/

namespace LINQLargeData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate LINQ Large Data in C# with Visual Studio\n");

            // Generating a large data sequence
            IEnumerable<int> largeNumbers = Enumerable.Range(1, 1000000);

            // Using LINQ to find all numbers divisible by both 3 and 5
            var filteredNumbers = largeNumbers.Where(num => num % 3 == 0 && num % 5 == 0);

            Console.WriteLine("Numbers divisible by 3 and 5 (First 10):");
            foreach (var num in filteredNumbers.Take(10))
            {
                Console.WriteLine(num);
            }
        }
    }
}