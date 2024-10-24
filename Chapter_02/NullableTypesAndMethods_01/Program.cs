// Program to demonstrate Nullable Types and Methods in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace NullableTypesAndMethods_01
{
    internal class Program
    {
        // Method that takes a nullable integer as a parameter.
        public static void CheckAge(int? age)
        {
            // Using a conditional check to see if 'age' has a value.
            if (age.HasValue)
            {
                // Output the age if it is not null.
                Console.WriteLine($"Age: {age}");
            }
            else
            {
                // If 'age' is null, print a message.
                Console.WriteLine("Age is not specified");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Nullable Types and Methods in C# with Visual Studio\n");

            // Calling 'CheckAge' with a valid age.
            CheckAge(25); // Output: Age is: 25

            // Calling 'CheckAge' with a nullable integer.
            CheckAge(null); // Output: Age is not specified.
        }
    }
}
