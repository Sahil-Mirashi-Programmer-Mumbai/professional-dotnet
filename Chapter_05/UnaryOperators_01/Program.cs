// Program to demonstrate Unary Operators in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace UnaryOperators_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Unary Operators in C# with Visual Studio\n");

            // Unary operators operate on a single operand and include increment (++), decrement (--), and negation (-)
            int count = 10;

            // Increment operator (++): increases value by 1
            count++;
            // Equivalent to: count = count + 1
            Console.WriteLine($"After increment: {count}"); // Outputs 11

            // Decrement operator (--): decreases value by 1
            count--;
            // Equivalent to: count = count - 1
            Console.WriteLine($"After decrement: {count}"); // Outputs 10

            // Unary negation (-): negates the value (multiplies by -1)
            int value = -count; // 'value' is set to -10
            Console.WriteLine($"Negated value: {value}");

            // Prefix vs Postfix increment example
            int x = 5;
            Console.WriteLine($"Initial value of x: {x}");
            Console.WriteLine($"Postfix increment (x++): {x++}"); // Outputs 5, then increments x to 6
            Console.WriteLine($"Value of x after postfix increment: {x}");
            Console.WriteLine($"Prefix increment (++x): {++x}"); // Increments x to 7, then outputs 7
        }
    }
}
