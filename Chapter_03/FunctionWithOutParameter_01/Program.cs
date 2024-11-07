// Program to demonstrate Function with Out Parameter in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace FunctionWithOutParameter_01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Function with Out Parameter in C# with Visual Studio\n");

            int area;

            CalculateArea(5, 7, out area);

            Console.WriteLine($"Area of Rectangle: {area}");
        }

        /// <summary>
        /// Function to calculate area and use out parameter to return the result
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <param name="area"></param>
        static void CalculateArea(int width, int height, out int area)
        {
            area = width * height;
        }
    }
}
