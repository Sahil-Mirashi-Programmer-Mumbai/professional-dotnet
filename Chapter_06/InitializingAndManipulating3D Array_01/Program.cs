﻿/*
     Program to demonstrate initializing and manipulating three dimensional array in C# with Visual Studio
     Programmer: Sahil Mirashi

    This example shows how to work with 3D arrays, which can represent data structures like spatial grids, game worlds, or time-series data.
    The nested loops allow accessing and modifying elements in the 3D array.
*/

namespace InitializingAndManipulating3D_Array_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate initializing and manipulating three dimensional array in C# with Visual Studio\n");

            // Declaring a three dimensional array
            int[,,] threeDimensionalArray =
            {
                { { 4, 7, 1}, { 2, 9, 1} },
                { { 1, 0, 4}, { 4, 1, 8 } }
            };

            // Accessing and modifying elements
            // Changing element at position [0, 1, 2]
            threeDimensionalArray[0, 1, 2] = 97;

            int firstDimensionCount = threeDimensionalArray.GetLength(0);
            int secondDimensionCount = threeDimensionalArray.GetLength(1);
            int thirdDimensionCount = threeDimensionalArray.GetLength(2);

            // Iterating over the first dimension
            for (int firstDimensionCounter = 0; firstDimensionCounter < firstDimensionCount; firstDimensionCounter++)
            {
                // Iterating over the second dimension
                for (int secondDimensionCounter = 0; secondDimensionCounter < secondDimensionCount; secondDimensionCounter++)
                {
                    // Iterating over the third dimension
                    for (int thirdDimensionCounter = 0; thirdDimensionCounter < thirdDimensionCount; thirdDimensionCounter++)
                    {
                        Console.Write($"Cube[{firstDimensionCounter}, {secondDimensionCounter}, {thirdDimensionCounter}] = {threeDimensionalArray[firstDimensionCounter, secondDimensionCounter, thirdDimensionCounter]} ");
                    }
                    // New line after each two dimensional layer
                    Console.WriteLine();
                }
                // Extra line to separate each 'cube slice'
                Console.WriteLine();
            }
        }
    }
}