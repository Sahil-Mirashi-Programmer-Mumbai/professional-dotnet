// Program to demonstrate Generic Interfaces in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace GenericInterfaces_01
{
    interface IRepository<T>
    {
        void Add(T item);
        T GetById(int id);
    }

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class ProductRepository : IRepository<Product>
    {
        public void Add(Product item)
        {
            Console.WriteLine($"Adding {item.Name}");
        }

        public Product GetById(int id)
        {
            return new Product { Id = id, Name = "Sample Product" };
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Generic Interfaces in C# with Visual Studio\n");

            IRepository<Product> repository = new ProductRepository();
            Product product = new Product { Id = 1, Name = "Laptop" };

            repository.Add(product);
            Console.WriteLine($"Getting product name by ID: {repository.GetById(1).Name}");
        }
    }
}
