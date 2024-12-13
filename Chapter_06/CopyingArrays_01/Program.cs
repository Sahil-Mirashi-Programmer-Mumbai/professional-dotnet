/*
     Program to demonstrate Copying Arrays in C# with Visual Studio
     Programmer: Sahil Mirashi

    This is useful when you need to create a backup or process data without modifying the original array.
*/

namespace CopyingArrays_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Copying Arrays in C# with Visual Studio\n");

            // Declaring and initializing the source array
            int[] sourceArray = { 8, 7, 9, 2, 1 };

            Console.WriteLine("Source Array");
            foreach (int element in sourceArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();

            // Declaring a destination array of the same size
            int[] destinationArray = new int[sourceArray.Length];

            // Copying elements from sourceArray to destinationArray
            // Array.Copy(sourceArray, destinationArray, sourceArray.Length) copies elements
            Array.Copy(sourceArray, destinationArray, sourceArray.Length);

            // Printing the copied array
            Console.WriteLine("Destination Array (After Copy):");
            foreach (int element in destinationArray)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
    }
}
