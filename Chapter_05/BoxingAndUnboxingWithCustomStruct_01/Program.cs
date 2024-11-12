// Program to demonstrate Boxing and Unboxing with Custom struct in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Structs, like the Point structure here, are value types.
    When boxed, a copy of the struct is placed on the heap.
*/

namespace BoxingAndUnboxingWithCustomStruct_01
{
    // Defining a custom struct
    struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"Point({X}, {Y})";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Boxing and Unboxing with Custom struct in C# with Visual Studio\n");

            // Declaring a struct instance (value type)
            Point point = new Point(10, 20);

            // Boxing the struct instance
            object boxedPoint = point; // Copying the struct data to the heap

            Console.WriteLine($"Boxed struct: {boxedPoint}");

            // Unboxing the struct back to a value type
            Point unboxedPoint = (Point)boxedPoint; // Extracting the value from the heap
            Console.WriteLine($"Unboxed struct: {unboxedPoint}");
        }
    }
}
