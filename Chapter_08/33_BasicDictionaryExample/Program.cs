/*
Program to demonstrate Basic Dictionary in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation:
- "Add" method adds key-value pairs to the dictionary.
- "ContainsKey" checks for the existence of a specific key.
- KeyValuePair allows iterating over both keys and values in the dictionary.

Application: Useful for scenarios where quick lookup by a unique key is required, such as storing student scores, configuration settings, etc.
*/

namespace BasicDictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Basic Dictionary in C# with Visual Studio\n");

            // Definition: A Dictionary is a collection of key-value pairs.
            // Keys must be unique, and each key maps to a value.

            // Creating a Dictionary where the key is a string and the value is an integer
            Dictionary<string, int> studentScores = new Dictionary<string, int>();

            // Adding key-value pairs to the Dictionary
            studentScores.Add("Alice", 85); // "Alice" is the key, 85 is the value
            studentScores.Add("Bob", 92);
            studentScores.Add("Charlie", 78);

            // Accessing a value using a key
            Console.WriteLine("Alice's score: " + studentScores["Alice"]);

            // Checking if a key exists
            if (studentScores.ContainsKey("Bob"))
            {
                Console.WriteLine("Bob's score: " + studentScores["Bob"]);
            }

            // Looping through all key-value pairs
            foreach (KeyValuePair<string, int> entry in studentScores)
            {
                Console.WriteLine($"Student: {entry.Key}, Score: {entry.Value}");
            }
        }
    }
}