/*
Program to demonstrate LINQ With Dictionary in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: LINQ simplifies filtering, transformation, and querying data in dictionaries.
Application: Ideal for building dynamic queries in applications like e - commerce platforms.
*/

namespace LINQWithDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate LINQ With Dictionary in C# with Visual Studio\n");

            // Dictionary with product prices
            Dictionary<string, decimal> products = new Dictionary<string, decimal>
            {
                { "Laptop", 1000m },
                { "Mouse", 25m },
                { "Keyboard", 45m },
                { "Monitor", 300m },
                { "Desk", 150m }
            };

            // Filtering products over $100
            var expensiveProducts = products.Where(p => p.Value > 100);

            Console.WriteLine("Products priced over $100:");
            foreach (var product in expensiveProducts)
            {
                Console.WriteLine($"{product.Key}: ${product.Value}");
            }

            // Transforming product names to uppercase
            var upperCaseProducts = products.ToDictionary(p => p.Key.ToUpper(), p => p.Value);

            Console.WriteLine("\nProducts with names in uppercase:");
            foreach (var product in upperCaseProducts)
            {
                Console.WriteLine($"{product.Key}: ${product.Value}");
            }
        }
    }
}