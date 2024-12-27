/*
Program to demonstrate LINQ Grouping in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: "group word by word[0]" groups words by their first character.
Application: Categorizing data into meaningful groups for reports or analytics.
*/

namespace LINQGrouping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate LINQ Grouping in C# with Visual Studio\n");

            // List of words
            List<string> words = new List<string> { "apple", "banana", "apricot", "blueberry", "cherry" };

            // Grouping words by their first letter
            var groupedWords = from word in words
                               group word by word[0];

            // Displaying grouped words
            foreach (var group in groupedWords)
            {
                Console.WriteLine($"Words starting with '{group.Key}':");
                foreach (var word in group)
                {
                    Console.WriteLine($" - {word}");
                }
            }
        }
    }
}