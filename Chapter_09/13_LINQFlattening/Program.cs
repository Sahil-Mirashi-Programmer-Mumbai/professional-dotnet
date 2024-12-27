/*
Program to demonstrate LINQ Flattening in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: LINQ's SelectMany flattens hierarchical collections into a single sequence.
Application: Transforming nested structures like JSON arrays or hierarchical data.
*/

namespace LINQFlattening
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate LINQ Flattening in C# with Visual Studio\n");

            // Nested list of integers
            List<List<int>> nestedNumbers = new List<List<int>>
            {
                new List<int> { 1, 2, 3 },
                new List<int> { 4, 5 },
                new List<int> { 6, 7, 8 }
            };

            // Flattening nested lists into a single sequence
            var flattenedNumbers = nestedNumbers.SelectMany(numbers => numbers);

            Console.WriteLine("Flattened Numbers:");
            foreach (var num in flattenedNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}