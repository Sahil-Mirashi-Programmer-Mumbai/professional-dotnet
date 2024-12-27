/*
Program to demonstrate LINQ Basics in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: The LINQ query "from num in numbers where num > 5 select num" filters the list.
Application: Useful for querying data collections without complex loops.
*/

namespace LINQBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate LINQ Basics in C# with Visual Studio\n");

            // LINQ Definition:
            // LINQ (Language Integrated Query) allows querying collections (arrays, lists, etc.) 
            // using SQL-like syntax directly within C#. It simplifies data manipulation.

            // Sample list of integers
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Using LINQ to filter numbers greater than 5
            var filteredNumbers = from num in numbers
                                  where num > 5
                                  select num;

            // Displaying filtered numbers
            Console.WriteLine("Numbers greater than 5:");
            foreach (var number in filteredNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}