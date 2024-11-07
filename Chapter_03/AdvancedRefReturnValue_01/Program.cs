// Program to demonstrate advanced ref return value in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace AdvancedRefReturnValue_01
{
    internal class Program
    {
        static ref int GetElement(ref int[] numbers, int index)
        {
            return ref numbers[index];
        }

        static void Main()
        {
            Console.WriteLine("Program to demonstrate advanced ref return value in C# with Visual Studio\n");

            int[] numbers = { 7, 9, 1, 5 };

            ref int element = ref GetElement(ref numbers, 1);

            // Modifying the element directly affects the original array
            element = 70;

            Console.WriteLine(string.Join(", ", numbers)); // Output: 7, 70, 1, 5
        }
    }
}
