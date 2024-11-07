// Program to demonstrate Function with Ref Parameter in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace FunctionWithRefParameter_01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Function with Ref Parameter in C# with Visual Studio\n");

            int number = 10;

            // Passing number by reference to the SquareNumber function.
            Square(ref number);

            Console.WriteLine($"Square: {number}"); // Output: Square: 100
        }

        // Function to square a number using ref parameter.
        static void Square(ref int number)
        {
            number *= number; // Multiply number by itself
        }
    }
}
