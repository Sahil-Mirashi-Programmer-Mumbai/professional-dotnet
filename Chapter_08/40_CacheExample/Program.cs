/*
Program to demonstrate Cache Example in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: Dictionaries are excellent for implementing simple caching mechanisms.
Application: Optimize performance by avoiding repeated computation or database calls.
*/

namespace CacheExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Cache Example in C# with Visual Studio\n");

            // Simple cache implemented using a Dictionary
            Dictionary<int, string> cache = new Dictionary<int, string>();

            // Function to simulate data retrieval with caching
            string GetData(int key)
            {
                if (cache.ContainsKey(key))
                {
                    Console.WriteLine($"Cache hit for key {key}");
                    return cache[key];
                }
                else
                {
                    Console.WriteLine($"Cache miss for key {key}, fetching data...");
                    string value = $"Data for key {key}"; // Simulated data retrieval
                    cache[key] = value; // Store in cache
                    return cache[key];
                }
            }

            // Accessing data
            Console.WriteLine(GetData(1)); // Cache miss
            Console.WriteLine(GetData(1)); // Cache hit
        }
    }
}