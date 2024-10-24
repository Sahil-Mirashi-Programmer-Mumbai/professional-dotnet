// Program to demonstrate Null Coalescing Operator in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace NullCoalescingOperator_01
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Program to demonstrate Null Coalescing Operator in C# with Visual Studio\n");

            // Nullable string declared and initialized with null.
            string? name = null;

            // Using the null-coalescing operator (??) to provide a default value.
            string result = name ?? "Nick";

            Console.WriteLine($"Result: {result}"); // Output: Nick

        }
    }
}
