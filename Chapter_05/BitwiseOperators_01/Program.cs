// Program to demonstrate Bitwise Operators in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace BitwiseOperators_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Bitwise Operators in C# with Visual Studio\n");

            // Bitwise operators operate on binary representations of integers
            int a = 5;  // Binary: 0101
            int b = 3;  // Binary: 0011

            // '&' (AND) - Performs bitwise AND operation
            int andResult = a & b; // Binary result: 0001 (decimal: 1)
            Console.WriteLine($"Bitwise AND: {a} & {b} = {andResult}");

            // '|' (OR) - Performs bitwise OR operation
            int orResult = a | b; // Binary result: 0111 (decimal: 7)
            Console.WriteLine($"Bitwise OR: {a} | {b} = {orResult}");

            // '^' (XOR) - Performs bitwise exclusive OR operation
            int xorResult = a ^ b; // Binary result: 0110 (decimal: 6)
            Console.WriteLine($"Bitwise XOR: {a} ^ {b} = {xorResult}");

            // '~' (NOT) - Performs bitwise complement (inverts bits)
            int notResult = ~a; // Binary result: 1010 (in 2's complement form)
            Console.WriteLine($"Bitwise NOT: ~{a} = {notResult}");

            // Bitwise shift operators
            int leftShiftResult = a << 1; // Shifts bits left by 1 position (equivalent to multiplying by 2)
            Console.WriteLine($"Left shift: {a} << 1 = {leftShiftResult}");

            int rightShiftResult = a >> 1; // Shifts bits right by 1 position (equivalent to dividing by 2)
            Console.WriteLine($"Right shift: {a} >> 1 = {rightShiftResult}");
        }
    }
}
