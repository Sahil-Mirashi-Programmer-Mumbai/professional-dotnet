// Program to demonstrate multiplication of two matrices in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace MultiplicationOfTwoMatrices_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate multiplication of two matrices in C# with Visual Studio\n");

            // Matrix A   Matrix B   Result
            // 1 2        2 0        4    6
            // 3 4        1 3        10   12

            // Declaring and initializing two matrices for multiplication
            int[,] firstMatrix = { { 1, 2 }, { 3, 4 } };
            int[,] secondMatrix = { { 2, 0 }, { 1, 3 } };

            int firstMatrixRowCount = firstMatrix.GetLength(0);
            int firstMatrixColumnCount = firstMatrix.GetLength(1);
            int secondMatrixColumnCount = secondMatrix.GetLength(1);

            // Resultant matrix to store the product
            int[,] resultMatrix = new int[firstMatrixRowCount, firstMatrixColumnCount];

            // Matrix multiplication logic
            // Iterating over rows of firstMatrix
            for (int firstMatrixRowCounter = 0; firstMatrixRowCounter < firstMatrixRowCount; firstMatrixRowCounter++)
            {
                for (int secondMatrixColumnCounter = 0; secondMatrixColumnCounter < secondMatrixColumnCount; secondMatrixColumnCounter++)
                {
                    for(int multiplicationCounter  = 0; multiplicationCounter < firstMatrixColumnCount; multiplicationCounter++)
                    {
                        resultMatrix[firstMatrixRowCounter, secondMatrixColumnCounter] += firstMatrix[firstMatrixRowCounter, multiplicationCounter] * secondMatrix[multiplicationCounter, secondMatrixColumnCounter];
                    }
                }
            }

            // Printing the resultant matrix
            Console.WriteLine("Result of Matrix Multiplication:");
            for (int resultMatrixRowCounter = 0; resultMatrixRowCounter < resultMatrix.GetLength(0); resultMatrixRowCounter++)
            {
                for (int resultMatrixColumnCounter = 0; resultMatrixColumnCounter < resultMatrix.GetLength(1); resultMatrixColumnCounter++)
                {
                    Console.Write($"{resultMatrix[resultMatrixRowCounter, resultMatrixColumnCounter]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
