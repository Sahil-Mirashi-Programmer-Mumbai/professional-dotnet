// Program to demonstrate Boxing Unboxing with Collections in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    ArrayList is a non - generic collection. When storing value types, boxing occurs.
    Generic collections (e.g., List<int>) avoid this by storing value types directly without boxing.
*/

using System.Collections;

namespace BoxingUnboxingWithCollections_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Boxing Unboxing with Collections in C# with Visual Studio\n");

            // Using ArrayList which stores elements as objects (non-generic collection)
            ArrayList list = new ArrayList();

            // Boxing occurs when adding value types
            list.Add(42); // The int value 42 is boxed
            list.Add(99); // Another boxing operation

            // Accessing and unboxing elements
            int value1 = (int)list[0]; // Unboxing occurs here
            int value2 = (int)list[1]; // Unboxing again

            Console.WriteLine($"Values retrieved from ArrayList: {value1}, {value2}");
        }

    }
}
