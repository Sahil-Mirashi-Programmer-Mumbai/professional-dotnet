/*
Program to demonstrate LINQ Custom Comparisons in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: "StringComparer.OrdinalIgnoreCase" allows case-insensitive comparisons in LINQ queries.
Application: Useful in deduplicating data from inconsistent sources.
*/

namespace LINQCustomComparisons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate LINQ Custom Comparisons in C# with Visual Studio\n");

            // List of strings with mixed cases
            List<string> words = new List<string> { "Apple", "banana", "CHERRY", "apple" };

            // Using LINQ to filter case-insensitive duplicates
            var uniqueWords = words.Distinct(StringComparer.OrdinalIgnoreCase);

            Console.WriteLine("Unique Words (Case-Insensitive):");
            foreach (var word in uniqueWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}