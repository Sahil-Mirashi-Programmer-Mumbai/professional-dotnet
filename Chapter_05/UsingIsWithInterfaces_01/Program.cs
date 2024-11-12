// Program to demonstrate Using is with Interfaces in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace UsingIsWithInterfaces_01
{
    // Defining an interface
    interface IShape
    {
        void Draw();
    }

    // Implementing the interface in a class
    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Using is with Interfaces in C# with Visual Studio\n");

            object shape = new Circle();

            // Checking if 'shape' implements the IShape interface using 'is'
            if (shape is IShape drawableShape)
            {
                // Calling the interface method since the cast succeeded
                drawableShape.Draw();
            }
            else
            {
                Console.WriteLine("The object does not implement IShape.");
            }

            // Using 'as' to safely cast to an interface type
            IShape? shapeAsIShape = shape as IShape;
            if (shapeAsIShape != null)
            {
                // Since the cast succeeded, we can use 'shapeAsIShape' as an IShape instance
                shapeAsIShape.Draw();
            }
            else
            {
                Console.WriteLine("The 'as' cast failed.");
            }
        }
    }
}
