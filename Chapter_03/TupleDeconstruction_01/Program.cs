// Program to demonstrate Tuple Deconstruction in C# with Visual Studio
// Programmer: Sahil Mirashi

using System.Diagnostics;
using System.Reflection;
using System.Xml.Linq;

namespace TupleDeconstruction_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Tuple Deconstruction in C# with Visual Studio\n");

            // Create a tuple with three values.
            var product = (1, "Mobile", 40000);

            // Deconstruct the tuple into separate variables.
            var (Id, Name, Price) = product;

            // Deconstruct the tuple into separate variables.
            Console.WriteLine($"ID: {Id}"); // Output: ID: 1
            Console.WriteLine($"Name: {Name}"); // Output: Name: Mobile
            Console.WriteLine($"Price: {Price}"); // Output: Price: 40000
        }
    }
}
