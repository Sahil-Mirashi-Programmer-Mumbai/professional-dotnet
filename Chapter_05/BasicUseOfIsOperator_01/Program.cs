// Program to demonstrate Basic Use of is Operator in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace BasicUseOfIsOperator_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Basic Use of is Operator in C# with Visual Studio\n");

            object someValue = "Hello, world!"; // Declaring an object type variable

            // The 'is' operator checks if an object is of a specified type
            if (someValue is string) // Evaluates to true because 'someValue' is a string
            {
                // Safe to cast 'someValue' to string here since the 'is' check passed
                Console.WriteLine($"The object is a string with value: {(string)someValue}");
            }
            else
            {
                Console.WriteLine("The object is not a string.");
            }

            // Example with a different type
            someValue = 42;
            // The 'is' check will fail because 'someValue' is an int, not a string
            if (someValue is string)
            {
                Console.WriteLine("This code won't run.");
            }
            else
            {
                Console.WriteLine($"The object is not a string. Actual type: {someValue.GetType()}");
            }
        }
    }
}
