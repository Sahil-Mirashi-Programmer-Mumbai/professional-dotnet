// Program to demonstrate difference between ref and out in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace DifferenceBetweenRefAndOut_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate difference between ref and out in C# with Visual Studio\n");

            int number_1 = 10;
            int number_2;

            // Both 'ref' and 'out' are used to pass arguments by reference, but they behave differently.
            ModifyRef(ref number_1);
            Console.WriteLine($"Using ref: {number_1}");

            ModifyOut(out number_2);
            Console.WriteLine($"Using out: {number_2}");
        }

        static void ModifyRef(ref int number)
        {
            // 'ref' requires the variable to be initialized before passing.
            number += 10;
        }

        static void ModifyOut(out int number)
        {
            // 'out' does not require initialization before passing.
            number = 50;
        }
    }
}
