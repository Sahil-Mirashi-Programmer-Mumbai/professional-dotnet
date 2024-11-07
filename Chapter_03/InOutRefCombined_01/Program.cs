// Program to demonstrate in out ref combined in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace InOutRefCombined_01
{
    internal class Program
    {
        static void Multiply(ref int refParam, in int inParam, out int outParam)
        {
            // Modify 'refParam' using 'ref'
            refParam *= refParam;

            // Cannot modify 'inParam'

            // Must assign a value to 'outParam' before the method ends
            outParam = refParam * inParam;
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate in out ref combined in C# with Visual Studio\n");

            int firstArgument = 10;
            int secondArgument;

            // 'in' and 'ref' parameters must be initialized before being passed to the method
            Multiply(ref firstArgument, in firstArgument, out secondArgument);

            Console.WriteLine($"First Argument: {firstArgument} Second Argument: {secondArgument}"); // Output: First Argument: 100 Second Argument: 10000
        }
    }
}
