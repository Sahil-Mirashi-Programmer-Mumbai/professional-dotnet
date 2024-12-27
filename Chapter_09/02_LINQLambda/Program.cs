/*
Program to demonstrate LINQ Lambda in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: Lambda expressions are concise inline functions.
"name => name.StartsWith('A')" is a lambda used in the LINQ query.
Application: Quickly filter or manipulate data collections with short logic.
*/

namespace LINQLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate LINQ Lambda in C# with Visual Studio\n");

            // Sample list of strings
            List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };

            // Using LINQ with lambda expression to filter names starting with 'A'
            var filteredNames = names.Where(name => name.StartsWith("A"));

            // Displaying filtered names
            Console.WriteLine("Names starting with 'A':");
            foreach (var name in filteredNames)
            {
                Console.WriteLine(name);
            }      
        }
    }
}