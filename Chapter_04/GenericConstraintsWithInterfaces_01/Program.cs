// Program to demonstrate Generic Constraints With Interfaces in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    The DisplayService<T> class is constrained to types that implement IDisplayable, enforcing a contract on T.
    In Show(T item), item.Display() is called, demonstrating how the interface constraint allows use of Display.
    Application: Constraints are helpful when a generic class or method depends on specific functionality from the type parameter.
*/

namespace GenericConstraintsWithInterfaces_01
{
    // Define interface with Display method
    interface IDisplayable
    {
        void Display();
    }

    // Implement IDisplayable interface in Product class
    class Product : IDisplayable
    {
        public string Name { get; set; }

        public void Display()
        {
            Console.WriteLine($"Product: {Name}");
        }
    }

    // Generic class where T must implement IDisplayable interface
    class DisplayService<T> where T : IDisplayable
    {
        public void Show(T item)
        {
            item.Display(); // Call display method on item of type T
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Generic Constraints With Interfaces in C# with Visual Studio\n");

            DisplayService<Product> service = new DisplayService<Product>();
            Product product = new Product { Name = "Laptop" };
            service.Show(product);
        }
    }
}
