// Program to demonstrate Using ref Keyword for Value Update in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace UsingRefKeywordForValueUpdate_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Using ref Keyword for Value Update in C# with Visual Studio\n");

            // Declare and initialize a variable.
            int number = 10;

            Console.WriteLine($"Before method calling: {number}");

            // Pass the variable to the method using 'ref'.
            // 'ref' allows the method to modify the original variable.
            AddFive(ref number);

            Console.WriteLine($"After method calling: {number}");
        }

        // Method that takes an argument by reference.
        // Using 'ref' ensures the original value gets modified.
        static void AddFive(ref int number)
        {
            number += 5;
        }

    }
}
