/*
Program to demonstrate Bi-directional Mapping in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: Using two dictionaries allows mapping in both directions.
Application: Useful for scenarios like user ID to username mapping.
*/

namespace BiDirectionalMapping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Bi-directional Mapping in C# with Visual Studio\n");

            // Two Dictionaries for bi-directional mapping
            Dictionary<int, string> idToName = new Dictionary<int, string>();
            Dictionary<string, int> nameToId = new Dictionary<string, int>();

            // Adding data to both dictionaries
            idToName[1] = "Alice";
            idToName[2] = "Bob";
            nameToId["Alice"] = 1;
            nameToId["Bob"] = 2;

            // Accessing data in both directions
            Console.WriteLine($"ID 1 corresponds to {idToName[1]}");
            Console.WriteLine($"Name 'Bob' corresponds to ID {nameToId["Bob"]}");
        }
    }
}