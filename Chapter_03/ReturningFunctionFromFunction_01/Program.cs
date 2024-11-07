// Program to demonstrate Returning Function from Function in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace ReturningFunctionFromFunction_01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Returning Function from Function in C# with Visual Studio\n");

            Func<int, int> doubler = GetMultiplierFunction(2);
            Console.WriteLine($"Doubled: {doubler(5)}"); // Output: Doubled: 10
        }

        static Func<int, int> GetMultiplierFunction(int multiplier)
        {
            return number => number * multiplier;
        }
    }
}
