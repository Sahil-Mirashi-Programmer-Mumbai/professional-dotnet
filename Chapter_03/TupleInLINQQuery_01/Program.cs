// Program to demonstrate Tuple in LINQ Query in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace TupleInLINQQuery_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Tuple in LINQ Query in C# with Visual Studio\n");

            // Array of numbers
            int[] numbers = { 4, 8, 9, 7 };

            // Using LINQ query to select tuples with square values
            var results = numbers.Select(number => (Number: number, Square: number * number));

            foreach (var result in results)
            {
                Console.WriteLine($"Number: {result.Number} Square: {result.Square}");
            }
        }
    }
}
