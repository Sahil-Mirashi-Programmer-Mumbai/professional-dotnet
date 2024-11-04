// Program to demonstrate Interfaces With Collections in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace InterfacesWithCollections_01
{
    interface IProduct
    {
        string Name { get; }
        decimal Price { get; }
    }

    class Product : IProduct
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public Product(string name, decimal price)
        { 
            Name = name;
            Price = price;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Interfaces With Collections in C# with Visual Studio\n");

            List<IProduct> products = new List<IProduct>
            {
                new Product("Laptop", 40000M),
                new Product("Mobile", 35000M),
                new Product("Lamp", 2000M)
            };
            
            foreach (var product in products)
            {
                Console.WriteLine($"Product Name: {product.Name} Product Price: {product.Price}");
            }

        }
    }
}
