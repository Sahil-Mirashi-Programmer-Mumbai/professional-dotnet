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

            // Pass the variable to the method using 'ref'.
            // 'ref' allows the method to modify the original variable.
            Console.WriteLine("Before: " + number); // Output: Before: 10

            AddFive(ref number);
            
            Console.WriteLine("After: " + number);  // Output: After: 15
        }

        // Method that takes an argument by reference.
        // Using 'ref' ensures the original value gets modified.
        public static void AddFive(ref int num)
        {
            num += 5; // Modify the original value
        }

    }
}
