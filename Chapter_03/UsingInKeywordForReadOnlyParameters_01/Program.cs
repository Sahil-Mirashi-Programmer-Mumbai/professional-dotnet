// Program to demonstrate using in keyword for readonly parameters in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace UsingInKeywordForReadOnlyParameters_01
{
    internal class Program
    {
        // Method that takes a read-only argument using 'in'.
        static void ShowValue(in int value)
        {
            Console.WriteLine($"Value: {value}");

            // Uncommenting the line below will cause a compile error as 'in' prevents modification.
            // value = 200;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate using in keyword for readonly parameters in C# with Visual Studio\n");

            // Initialize a value.
            int number = 100;

            // Pass the value to the method using 'in'.
            // 'in' ensures the method cannot modify the original value.
            ShowValue(in number);

        }
    }
}
