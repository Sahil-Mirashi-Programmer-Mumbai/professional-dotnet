// Program to demonstrate Internal Access Modifier With Assemblies in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace InternalAccessModifierWithAssemblies_01
{
    class Calculator
    {
        // Internal method accessible within the same assembly
        internal int Add(int number_1, int number_2)
        {
            return number_1 + number_2;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Internal Access Modifier With Assemblies in C# with Visual Studio\n");

            Calculator calculator = new Calculator();
            Console.WriteLine($"Sum: {calculator.Add(5, 7)}"); // Output: Sum: 12
        }
    }
}