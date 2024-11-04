// Program to demonstrate Access Modifiers With Interfaces in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace AccessModifiersWithInterfaces_01
{
    public interface IMath
    {
        // Public by default in interface
        int Add(int number_1, int number_2);
    }

    class MathOperation : IMath
    {
        public int Add(int number_1, int number_2)
        {
            return number_1 + number_2;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Access Modifiers With Interfaces in C# with Visual Studio\n");

            IMath mathOperation = new MathOperation();
            Console.WriteLine($"Sum: {mathOperation.Add(5, 2)}"); // Output: Sum: 7
        }
    }
}
