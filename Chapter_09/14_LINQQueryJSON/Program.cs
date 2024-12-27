/*
Program to demonstrate LINQ Query JSON in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: LINQ seamlessly integrates with deserialized JSON for advanced querying.
Application: Filtering and transforming API responses or configuration files.
*/

using Newtonsoft.Json;

namespace LINQQueryJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate LINQ Query JSON in C# with Visual Studio\n");

            // JSON data representing products
            string jsonData = @"
            [
                { 'Name': 'Laptop', 'Price': 800 },
                { 'Name': 'Tablet', 'Price': 400 },
                { 'Name': 'Phone', 'Price': 600 }
            ]";

            // Parsing JSON data into a list of dynamic objects
            var products = JsonConvert.DeserializeObject<List<dynamic>>(jsonData);

            // LINQ query to filter products costing more than 500
            var expensiveProducts = from product in products
                                    where product.Price > 500
                                    select product;

            Console.WriteLine("Expensive Products:");
            foreach (var product in expensiveProducts)
            {
                Console.WriteLine($"{product.Name} - ${product.Price}");
            }
        }
    }
}