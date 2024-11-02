// Program to demonstrate ref Requires Variable Initialization in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace RefRequiresVariableInitialization_01
{
    internal class Program
    {
        static int AddTen(ref int number)
        {
            return number += 10;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate ref Requires Variable Initialization in C# with Visual Studio\n");

            int number;

            // Uncommenting the line below will cause a compile error because the 'ref' variable must be initialized.
            // AddTen(ref number); // Error: Use of unassigned local variable 'number'

            // Properly initialize the variable.
            number = 10;

            Console.WriteLine($"Value after AddTen: {AddTen(ref number)}"); // Output: Value after AddTen: 20
        }
    }
}
