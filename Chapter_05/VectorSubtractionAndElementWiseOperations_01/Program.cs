using System.Numerics;

namespace VectorSubtractionAndElementWiseOperations_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector<float> firstVector = new Vector<float>(new float[] { 13.05F, 17.45F, 45.01F, 71.09F });
            Vector<float> secondVector = new Vector<float>(new float[] { 3.05F, 7.45F, 35.01F, 7.09F });

            Vector<float> result = firstVector - secondVector;

            for(int i = 0; i < Vector<float>.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
