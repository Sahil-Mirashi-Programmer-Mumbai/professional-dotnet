// Program to demonstrate Basic Demonstration of Boxing and Unboxing in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Boxing occurs when a value type is converted to an object type or any interface type it implements.
    The value is copied to the heap, and a reference to that heap memory is created.
    Unboxing is the reverse operation, extracting the value type from the object.
*/

namespace BasicDemonstrationOfBoxingAndUnboxing_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Basic Demonstration of Boxing and Unboxing in C# with Visual Studio\n");

            // Example of Boxing
            // Boxing is the process of converting a value type (like int) to an object type
            int value = 123; // Declaring a value type variable 'value' of type int
            object boxedValue = value; // Boxing 'value' into an object. This involves copying the value into the managed heap.

            Console.WriteLine($"The boxed value is: {boxedValue}");

            // Example of Unboxing
            // Unboxing is the process of converting an object back to a value type
            int unboxedValue = (int)boxedValue; // Unboxing: Extracting the value from the object
            Console.WriteLine($"The unboxed value is: {unboxedValue}");
        }
    }
}
