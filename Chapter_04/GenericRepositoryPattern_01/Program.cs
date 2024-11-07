// Program to demonstrate Generic Repository Pattern in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace GenericRepositoryPattern_01
{
    // Generic repository interface, defining CRUD operation
    interface IRepository<T> where T : class
    {
        void Add(T item); // Adds entity of generic type T
        void Remove(T item); // Removes an entity of generic type T
        IEnumerable<T> GetAll(); // Returns all entities of generic type T
    }

    // Implementation of generic repository
    class Repository<T> : IRepository<T> where T : class
    {
        private readonly List<T> _genericList = new List<T>();

        public void Add(T item)
        {
            _genericList.Add(item);
        }

        public void Remove(T item)
        {
            _genericList.Remove(item);
        }

        public IEnumerable<T> GetAll()
        {
            return _genericList;
        }
    }

    // Entity classes
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Generic Repository Pattern in C# with Visual Studio\n");

            // Creating repository of product
            Repository<Product> productRepository = new Repository<Product>();
            productRepository.Add(new Product { Name = "Laptop", Price = 40000M });
            productRepository.Add(new Product { Name = "Mobile", Price = 20000M });

            // Creating repository of customer
            Repository<Customer> customerRepository = new Repository<Customer>();
            customerRepository.Add(new Customer { Id = 1, Name = "Tom" });
            customerRepository.Add(new Customer { Id = 2, Name = "Mike" });

            Console.WriteLine("Products");
            foreach( var product in productRepository.GetAll() )
            {
                Console.WriteLine($"Product: {product.Name} Price: {product.Price}");
            }

            Console.WriteLine("Customers");
            foreach (var customer in customerRepository.GetAll())
            {
                Console.WriteLine($"Product: {customer.Id} Price: {customer.Name}");
            }
        }
    }
}
