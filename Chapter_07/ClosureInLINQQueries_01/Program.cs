// Program to demonstrate Closure in LINQ Queries in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Explanation:
    - LINQ expressions often use closures to capture variables.
    - Here, the lambda expression captures 'startsWith' and uses it to filter elements.
    - This shows how closures enable dynamic query construction.
*/

namespace ClosureInLINQQueries_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Closure in LINQ Queries in C# with Visual Studio\n");

            string[] fruits = { "apple", "banana", "apricot", "cherry" };
            char startsWith = 'a';

            // Closure captures 'startsWith'
            var filteredFruits = fruits.Where(fruit => fruit.StartsWith(startsWith));

            foreach (var fruit in filteredFruits)
            {
                // Output: apple apricot
                Console.WriteLine(fruit);
            }
        }
    }
}
