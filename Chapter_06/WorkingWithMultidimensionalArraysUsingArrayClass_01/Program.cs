// Program to demonstrate working with multi-dimensional arrays using Array class in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace WorkingWithMultidimensionalArraysUsingArrayClass_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate working with multi-dimensional arrays using Array class in C# with Visual Studio\n");

            // Creating a 2D array using Array class
            int[,] matrix = new int[3, 3];

            int rowCount = matrix.GetLength(0);
            int columnCount = matrix.GetLength(1);

            // Initializing the array with values
            int value = 1;

            for (int row = 0; row < rowCount; row++)
            {
                for (int column = 0; column < columnCount; column++)
                {
                    matrix[row, column] = value;
                    value++;
                }
            }

            // Printing the 2D array
            Console.WriteLine("2D Array (Matrix):");
            for (int row = 0; row < rowCount; row++)
            {
                for (int column = 0; column < columnCount; column++)
                {
                    Console.Write($"{matrix[row, column]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
