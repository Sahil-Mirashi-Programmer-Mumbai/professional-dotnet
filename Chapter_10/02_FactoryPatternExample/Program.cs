/*
Definition:
Factory pattern defines an interface/zariaa for creating objects but allows subclass to alter type of object that will be created
It helps encapsulate object creation process.

Applications:
When the exact type of object required is determined dynamically at runtime.
When the creation process is complex and needs centralization.
*/

namespace FactoryPatternExample
{
    // Product interface
    public interface IShape
    {
        void Draw();
    }

    // Concrete Product 1
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Circle.");
        }
    }

    // Concrete Product 2
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Rectangle.");
        }
    }

    // Factory Class
    public class ShapeFactory
    {
        public IShape GetShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if (shapeType.Equals("Circle", StringComparison.OrdinalIgnoreCase))
            {
                return new Circle();
            }
            else if (shapeType.Equals("Rectangle", StringComparison.OrdinalIgnoreCase))
            {
                return new Rectangle();
            }
            return null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create factory instance
            ShapeFactory shapeFactory = new ShapeFactory();

            // Get a Circle object and call its Draw method
            IShape circle = shapeFactory.GetShape("Circle");
            circle?.Draw();

            // Get a Rectangle object and call its Draw method
            IShape rectangle = shapeFactory.GetShape("Rectangle");
            rectangle?.Draw();

            Console.ReadLine();
        }
    }
}

/*
Explanation of Code:
IShape interface:
Defines a common interface for all shapes, ensuring all shapes implement the Draw method.

Circle and Rectangle classes:
Concrete implementations of the IShape interface, each with its specific behavior for Draw.

ShapeFactory:
Contains the logic to create the appropriate object (Circle or Rectangle) based on the provided input.

Main method:
Demonstrates the usage of the factory by dynamically creating objects without exposing their instantiation logic.
*/