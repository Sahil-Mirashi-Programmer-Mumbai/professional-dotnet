// Program to demonstrate Basic use of as Operator in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace BasicUseOfAsOperator_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Basic use of as Operator in C# with Visual Studio\n");

            object someValue = "This is a string";

            // The 'as' operator attempts to cast an object to a specified type
            // If the cast fails, 'result' will be null
            string? result = someValue as string;

            if (result != null)
            {
                Console.WriteLine($"Casted using 'as': {result}");
            }
            else
            {
                Console.WriteLine("Cast failed. 'someValue' is not a string.");
            }

            // Attempting to use 'as' with a non-compatible type
            someValue = 123; // Integer type
            result = someValue as string; // This will fail and result in null
            if (result == null)
            {
                Console.WriteLine("The 'as' cast failed because 'someValue' is not a string.");
            }
        }
    }
}
