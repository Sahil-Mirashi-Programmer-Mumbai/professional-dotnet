// Program to demonstrate Tuple Returning Multiple Values From Method in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace TupleReturningMultipleValuesFromMethod_01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Tuple Returning Multiple Values From Method in C# with Visual Studio\n");

            // Call the method that returns area and perimeter
            var result = CalculateRectangle(10, 7);

            Console.WriteLine($"Area: {result.Area} Perimeter: {result.Perimeter}");
        }

        // Method returning multiple values as a tuple
        static (int Area, int Perimeter) CalculateRectangle(int width, int height)
        {
            return (width * height, 2 * (width + height));
        }
    }
}
