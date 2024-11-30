/*
Program to demonstrate Update and Remove Dictionary in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation:
- Dictionaries allow updating values by accessing them with their key.
- Use "Remove" to delete a key-value pair.

Application: Manage dynamically changing datasets like inventory or user profiles.
*/

namespace UpdateAndRemoveDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Update and Remove Dictionary in C# with Visual Studio\n");

            // Creating a Dictionary with string keys and double values
            Dictionary<string, double> productPrices = new Dictionary<string, double>
            {
                { "Apple", 0.99 }, // Initializing dictionary with values
                { "Banana", 0.59 },
                { "Cherry", 2.99 }
            };

            // Updating a value using its key
            productPrices["Apple"] = 1.09; // Changing the price of "Apple"

            // Removing an entry using its key
            productPrices.Remove("Banana"); // Removes the key "Banana" and its value

            // Displaying updated Dictionary
            foreach (var product in productPrices)
            {
                Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
            }
        }
    }
}