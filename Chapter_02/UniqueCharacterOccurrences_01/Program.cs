// Program to demonstrate Unique Character Occurrences in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace UniqueCharacterOccurrences_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Unique Character Occurrences in C# with Visual Studio\n");

            Console.Write("Enter a string: ");

            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Please enter a valid input");
            }
            else
            {
                Dictionary<char, int> occurences = UniqueCharacterOccurrences(input);

                foreach (var kvp in occurences)
                {
                    Console.WriteLine($"Character: {kvp.Key} Occurence: {kvp.Value}");
                }
            }
        }

        static Dictionary<char, int> UniqueCharacterOccurrences(string input)
        {
            Dictionary<char, int> CharacterCount = new Dictionary<char, int>();

            foreach(char key in input)
            {
                if(CharacterCount.ContainsKey(key))
                {
                    CharacterCount[key]++;
                }
                else
                {
                    CharacterCount[key] = 1;
                }
            }
            return CharacterCount;
        }
    }
}
