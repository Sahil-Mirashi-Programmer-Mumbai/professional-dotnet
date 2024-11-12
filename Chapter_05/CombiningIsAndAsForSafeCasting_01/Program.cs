// Program to demonstrate Combining is and as for Safe Casting in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace CombiningIsAndAsForSafeCasting_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Combining is and as for Safe Casting in C# with Visual Studio\n");

            object? someValue = null;

            // First, use 'is' to check if 'someValue' is of the specified type
            if (someValue is double)
            {
                // Safely use 'as' to cast 'someValue' to double
                double? castedValue = someValue as double?;
                if (castedValue != null)
                {
                    Console.WriteLine($"Casted value using 'as': {castedValue}");
                }
            }
            else
            {
                Console.WriteLine("The value is not a double.");
            }
        }
    }
}
