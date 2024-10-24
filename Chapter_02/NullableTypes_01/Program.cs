// Program to demonstrate Basic Usage of Nullable Types in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace NullableTypes_01
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Program to demonstrate Basic Usage of Nullable Types in C# with Visual Studio\n");

            // Declaring a nullable integer.
            // The '?' after 'int' means that 'number' can hold an integer value or be null.
            int? number = null;

            // Checking if 'number' has a value.
            if (number.HasValue)
            {
                Console.WriteLine($"Value: {number.Value}");
            }
            else
            {
                // Since 'number' is null, this line will execute.
                Console.WriteLine("number is null");
            }

            // Assigning a value to 'number'.
            number = 10;

            // Now 'number' has a value, so this line will execute.
            if (number.HasValue)
            {
                Console.WriteLine($"Value: {number.Value}"); // Output: 10
            }
        }
    }
}
