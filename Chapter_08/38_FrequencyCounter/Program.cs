/*
Program to demonstrate Frequency Counter in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: Dictionaries are ideal for frequency counting because of their O(1) key lookup time.
Application: Analyzing text data, building word clouds, or data analysis.
*/

namespace FrequencyCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Frequency Counter in C# with Visual Studio\n");

            string inputString = "hellowordcsharp";

            Dictionary<char, int> characterFrequency = new Dictionary<char, int>();

            foreach (char character in inputString)
            {
                characterFrequency[character] = characterFrequency.ContainsKey(character) ? (characterFrequency[character] + 1) : 1;
            }

            foreach (var character in characterFrequency)
            {
                Console.WriteLine($"Character: {character.Key} Frequency: {character.Value}");
            }
        }
    }
}