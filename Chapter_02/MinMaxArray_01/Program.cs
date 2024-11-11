// Program to demonstrate Min Max Array in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace MinMaxArray_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Min Max Array in C# with Visual Studio\n");
            int[] numbers = { 7, 9, 8, 1, 2 };

            int min = numbers[0];
            int max = numbers[0];

            foreach(int number in numbers)
            {
                if(number < min)
                {
                    min = number;
                }

                if(number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine($"Min: {min} Max: {max}");
            Console.WriteLine($"Min: {numbers.Min()} Max: {numbers.Max()}"); // Using built-in functions
        }
    }
}
