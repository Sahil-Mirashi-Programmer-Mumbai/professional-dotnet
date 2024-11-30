/*
Program to demonstrate Dictionary with LINQ in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: LINQ enables advanced querying of dictionary data.
Application: Filtering datasets based on specific criteria.
*/

namespace DictionaryWithLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Dictionary with LINQ in C# with Visual Studio\n");

            // Creating a Dictionary to store city populations
            Dictionary<string, int> cityPopulations = new Dictionary<string, int>
            {
                { "Mumbai", 20411000 },
                { "Delhi", 16787941 },
                { "Bangalore", 8443675 }
            };

            // LINQ query to find cities with populations above 10 million
            var largeCities = cityPopulations.Where(city => city.Value > 10000000);

            // Displaying the result
            Console.WriteLine("Cities with populations above 10 million:");
            foreach (var city in largeCities)
            {
                Console.WriteLine($"City: {city.Key}, Population: {city.Value}");
            }
        }
    }
}