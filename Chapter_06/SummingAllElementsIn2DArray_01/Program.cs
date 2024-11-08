// Program to demonstrate summing all elements in two dimensional array in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Demonstrates summing up all elements in a 2D array.
    Useful in applications like finding totals in tabular data or computing matrix properties.
*/

namespace SummingAllElementsIn2DArray_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate summing all elements in two dimensional array in C# with Visual Studio\n");

            int[,] twoDimensionalArray = new int[3, 3] { { 7, 9, 1 }, { 0, 2, 5 }, { 5, 8, 4 } };

            int sum = 0;
            int rowCount = twoDimensionalArray.GetLength(0);
            int columnCount = twoDimensionalArray.GetLength(1);

            for (int rowCounter = 0; rowCounter < rowCount; rowCounter++)
            {
                for (int columnCounter = 0; columnCounter < columnCount; columnCounter++)
                {
                    sum += twoDimensionalArray[rowCounter, columnCounter];
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
