// Program to demonstrate out to Return Multiple Values in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace UsingOutToReturnMultipleValues_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate out to Return Multiple Values in C# with Visual Studio\n");

            // Variables that will receive multiple outputs from the method.
            int _sum, _product;

            // Calling the method with 'out' parameters.
            Calculate(2, 5, out _sum, out _product);

            Console.WriteLine($"Sum: {_sum} Product: {_product}");
        }

        // Method to calculate sum and product using 'out' parameters.
        static void Calculate(int number_1, int number_2, out int sum, out int product)
        {
            sum = number_1 + number_2;
            product = number_1 * number_2;
        }
    }
}
