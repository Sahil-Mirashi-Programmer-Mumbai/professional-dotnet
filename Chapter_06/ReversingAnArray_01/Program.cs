// Program to demonstrate Reversing an Array in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Useful for reversing data for display, algorithms that require reverse order, or implementing stacks.
*/

namespace ReversingAnArray_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Reversing an Array in C# with Visual Studio\n");

            int[] numbers = { 8, 1, 4, 9, 0 };

            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();

            Array.Reverse(numbers);

            foreach(int number in numbers)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
