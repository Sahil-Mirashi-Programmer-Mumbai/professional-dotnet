// Program to demonstrate Assignment Operators with Compound Operations in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace AssignmentOperatorsWithCompoundOperations_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Assignment Operators with Compound Operations in C# with Visual Studio\n");

            // Assignment operators include '=', '+=', '-=', '*=', '/=', etc.
            int num = 10;

            // Simple assignment
            Console.WriteLine($"Initial value: {num}");

            // Compound assignment with addition
            num += 5; // Equivalent to: num = num + 5
            Console.WriteLine($"After += 5: {num}");

            // Compound assignment with subtraction
            num -= 3; // Equivalent to: num = num - 3
            Console.WriteLine($"After -= 3: {num}");

            // Compound assignment with multiplication
            num *= 2; // Equivalent to: num = num * 2
            Console.WriteLine($"After *= 2: {num}");

            // Compound assignment with division
            num /= 4; // Equivalent to: num = num / 4
            Console.WriteLine($"After /= 4: {num}");

            // Compound assignment with modulus
            num %= 3; // Equivalent to: num = num % 3
            Console.WriteLine($"After %= 3: {num}");
        }
    }
}
