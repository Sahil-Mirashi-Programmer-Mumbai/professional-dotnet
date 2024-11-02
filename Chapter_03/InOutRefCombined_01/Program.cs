// Program to demonstrate in out ref combined in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace InOutRefCombined_01
{
    internal class Program
    {
        internal static void Multiply(ref int refParam, in int inParam, out int outParam)
        {
            // Modfiy using 'ref'
            refParam *= 2;

            // Cannot modify 'inParam' as it is read-only 

            // Must assign value to 'outParam'
            outParam = refParam * inParam;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate in out ref combined in C# with Visual Studio\n");

            // 'in' and 'ref' parameters must be initialized before being passed to the method
            int first_argument = 10;
            int second_argument = 20;

            Multiply(ref first_argument, first_argument, out second_argument);

            Console.WriteLine($"First Argument: {first_argument} Second Argument: {second_argument}"); // Output: First Argument: 20 Second Argument: 400
        }
    }
}
