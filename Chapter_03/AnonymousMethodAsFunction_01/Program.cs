// Program to demonstrate Anonymous Method as Function in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace AnonymousMethodAsFunction_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Anonymous Method as Function in C# with Visual Studio\n");

            // Declares a delegate 'square' that takes one integer and returns an integer.
            // 'Func<int, int>' specifies a function delegate with one 'int' input and an 'int' return type.
            Func<int, int> square = delegate (int number) { return number * number; };

            Console.WriteLine($"Square: {square(5)}"); // Output: Square: 25
        }
    }
}
