using System.Numerics;

namespace BasicVectorAddition_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vector<T> represents a single vector for SIMD operations
            // Initializing two vectors with the same size and data type (int here)
            Vector<int> vector1 = new Vector<int>(new int[] { 1, 2, 3, 4 });
            Vector<int> vector2 = new Vector<int>(new int[] { 5, 6, 7, 8 });

            // Adding the vectors (element-wise addition)
            Vector<int> result = vector1 + vector2;

            // Printing the results
            Console.WriteLine("Resulting vector after addition:");
            for (int i = 0; i < Vector<int>.Count; i++)
            {
                // Accessing each element of the resulting vector
                Console.WriteLine(result[i]);
            }
        }
    }
}
