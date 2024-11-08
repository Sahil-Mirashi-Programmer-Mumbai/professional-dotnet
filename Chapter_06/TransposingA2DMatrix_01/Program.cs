// Program to demonstrate transposing a two dimensional matrix in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Transposing a matrix involves swapping rows with columns.
    Commonly used in mathematical transformations, computer graphics, and data analysis.
*/

namespace TransposingA2DMatrix_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate transposing a two dimensional matrix in C# with Visual Studio\n");

            int[,] twoDimensionalArray = { { 4, 8, 9 }, { 9, 3, 1 } };

            int rowCount = twoDimensionalArray.GetLength(0);
            int columnCount = twoDimensionalArray.GetLength(1);

            int[,] transposed = new int[columnCount, rowCount];

            for (int rowCounter = 0; rowCounter < rowCount; rowCounter++)
            {
                for (int columnCounter = 0; columnCounter < columnCount; columnCounter++)
                {
                    transposed[columnCounter, rowCounter] = twoDimensionalArray[rowCounter, columnCounter];
                }
            }

            for (int rowCounter = 0; rowCounter < transposed.GetLength(0); rowCounter++)
            {
                for (int columnCounter = 0; columnCounter < transposed.GetLength(1); columnCounter++)
                {
                    Console.Write($"{transposed[rowCounter, columnCounter]} ");
                }
                Console.WriteLine();
            }
        }
    }
}