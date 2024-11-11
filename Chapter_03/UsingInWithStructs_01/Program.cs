// Program to demonstrate using in with structs in C# with Visual Studio
// Programmer: Sahil Mirashi
/*
    Structs value types in C# that are used to represent lightweight objects that are typically small in size
    and do not require the overhead of a class. Structs are stored on the stack rather than the heap, which makes
    them more memory-efficient for small data structures.
*/
namespace UsingInWithStructs_01
{
    struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
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

            Point point = new Point(5, 7);
            ShowCoordinates(in point);
        }

        // The 'in' keyword prevents modifying the struct
        static void ShowCoordinates(in Point point)
        {
            Console.WriteLine($"X: {point.X} Y: {point.Y}");
        }
    }
}
