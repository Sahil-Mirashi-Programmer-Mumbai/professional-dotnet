// Program to demonstrate Swap Numbers Without Third Variable in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace SwapNumbersWithoutThirdVariable_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Swap Numbers Without Third Variable in C# with Visual Studio\n");

            int firstNumber = 12;
            int secondNumber = 7;

            Console.WriteLine($"Before swapping first number: {firstNumber} second number: {secondNumber}");

            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;

            Console.WriteLine($"After swapping first number: {firstNumber} second number: {secondNumber}");

        }
    }
}
