// Program to demonstrate Pattern Matching with is in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace PatternMatchingWithIs_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Pattern Matching with is in C# with Visual Studio\n");

            object someValue = 3.14;

            // Using the 'is' operator with pattern matching
            // Here, we check if 'someValue' is a double and simultaneously declare 'doubleValue'
            if (someValue is double doubleValue)
            {
                // Since 'someValue' is a double, 'doubleValue' is assigned the value of 'someValue'
                Console.WriteLine($"The value is a double: {doubleValue}");
            }
            else
            {
                Console.WriteLine("The value is not a double.");
            }

            // Example with a different type
            someValue = "Example string";
            // Pattern matching will check the type and provide a variable if the type matches
            if (someValue is string stringValue)
            {
                Console.WriteLine($"The string value is: {stringValue}");
            }
        }
    }
}
