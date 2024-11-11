// Program to demonstrate Sum Of Digits in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace SumOfDigits_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Sum Of Digits in C# with Visual Studio\n");

            Console.Write("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Number: {input} Sum of Digits: {SumOfDigits(input)}");
        }

        static int SumOfDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10; // Extract last digit from a number
                sum = sum + lastDigit; // Add last digit to sum
                number = number / 10; // Remove last digit from a number
            }
            return sum;
        }
    }
}
