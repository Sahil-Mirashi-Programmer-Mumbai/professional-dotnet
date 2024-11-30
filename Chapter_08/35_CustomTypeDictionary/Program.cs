/*
Program to demonstrate Custom Type Dictionary in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: Dictionaries can store custom objects as values, allowing flexibility in data modeling.
Application: Storing complex data structures for use cases like e-commerce catalogs.
*/

namespace CustomTypeDictionary
{
    // Custom class to represent a Product
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Custom Type Dictionary in C# with Visual Studio\n");

            // Using a Dictionary where keys are integers (Product IDs) and values are Product objects
            Dictionary<int, Product> productCatalog = new Dictionary<int, Product>();

            // Adding custom objects to the Dictionary
            productCatalog.Add(1, new Product { Name = "Laptop", Price = 1200.50 });
            productCatalog.Add(2, new Product { Name = "Smartphone", Price = 800.99 });

            // Accessing and displaying values
            foreach (var entry in productCatalog)
            {
                Console.WriteLine($"Product ID: {entry.Key}, Name: {entry.Value.Name}, Price: {entry.Value.Price}");
            }
        }
    }
}