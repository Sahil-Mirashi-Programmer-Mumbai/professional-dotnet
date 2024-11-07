// Program to demonstrate using in keyword for readonly parameters in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace UsingInKeywordForReadOnlyParameters_01
{
    internal class Program
    {
        // Method that takes a read-only argument using 'in'.
        static void ShowValue(in int number)
        {
            Console.WriteLine($"Number: {number}");

            // Un-commenting the below line will give compiler error 'in' restricts modification
            // number = 200; 
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate using in keyword for readonly parameters in C# with Visual Studio\n");

            int number;

            number = 100000;

            ShowValue(in number); // 'in' must be initialized before method calling
        }
    }
}
