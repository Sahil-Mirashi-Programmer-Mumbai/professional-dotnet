/*
Program to demonstrate Sort Dictionary by Key in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation:
- Dictionaries do not maintain order by default.
- LINQ can be used to sort dictionaries.

Application: Organize datasets when presenting data in a sorted order.
*/

namespace SortDictionaryByKey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Sort Dictionary by Key in C# with Visual Studio\n");

            // Creating a Dictionary with unsorted keys
            Dictionary<int, string> employeeIds = new Dictionary<int, string>
            {
                { 102, "Alice" },
                { 101, "Bob" },
                { 103, "Charlie" }
            };

            // Sorting the Dictionary by its keys
            var sortedByKey = employeeIds.OrderBy(entry => entry.Key);

            // Displaying the sorted Dictionary
            Console.WriteLine("Employees sorted by ID:");
            foreach (var entry in sortedByKey)
            {
                Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value}");
            }
        }
    }
}