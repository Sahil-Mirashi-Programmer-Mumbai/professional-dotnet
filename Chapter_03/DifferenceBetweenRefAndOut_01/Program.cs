// Program to demonstrate difference between ref and out in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace DifferenceBetweenRefAndOut_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate difference between ref and out in C# with Visual Studio\n");

            int number_1 = 7;
            int number_2;

            // Both 'ref' and 'out' are used to pass arguments by reference, but they behave differently.
            ModifyRef(ref number_1);
            Console.WriteLine($"Using ref: {number_1}");

            ModifyOut(out number_2);
            Console.WriteLine($"Using out: {number_2}");
        }

        static void ModifyRef(ref int number)
        {
            // 'ref' variable must be initialized before it's passed into the method
            number *= number;
        }

        static void ModifyOut(out int number)
        {
            // 'out' variable doesn’t need to be initialized before being passed to the method
            number = 10; // Must assign a value before the method ends
        }
    }
}
