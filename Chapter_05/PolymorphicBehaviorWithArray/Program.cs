// Program to demonstrate polymorphic behavior with an array in C# with Visual Studio
// Programmer: Sahil Mirashi

public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

public class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a square");
    }
}

namespace PolymorphicBehaviorWithArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate polymorphic behavior with an array in C# with Visual Studio\n");

            Shape[] shapes = { new Shape(), new Circle(), new Square() };

            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
