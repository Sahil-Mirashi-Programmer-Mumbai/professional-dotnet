// Program to demonstrate using in with structs in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace UsingInWithStructs_01
{
    struct Point
    {
        internal int X;
        internal int Y;

        internal Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate using in with structs in C# with Visual Studio\n");

            Point point = new Point(5, 10);
            ShowCoordinates(in point);
        }

        // The 'in' keyword prevents modifying the struct
        static void ShowCoordinates(in Point point)
        {
            Console.WriteLine($"X: {point.X} Y: {point.Y}"); // Output: X: 5 Y: 10
        }
    }
}
