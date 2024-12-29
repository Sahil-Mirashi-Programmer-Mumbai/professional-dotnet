/*
Definition
The Flyweight design pattern is a structural design pattern that minimizes memory usage by sharing common data among multiple objects.
It is particularly useful when dealing with a large number of objects that share similar characteristics.

The pattern separates intrinsic state (shared, invariant data) from extrinsic state (unique, context-specific data), allowing the former to be reused.
*/

// Flyweight Interface
public interface IShape
{
    void Draw(string color); // Accepts extrinsic state
}

// Concrete Flyweight Class
public class Circle : IShape
{
    private readonly string _shapeType; // Intrinsic state (shared)

    public Circle()
    {
        _shapeType = "Circle"; // Shared among all Circle instances
    }

    public void Draw(string color)
    {
        // 'color' is the extrinsic state provided by the client
        Console.WriteLine($"Drawing a {_shapeType} with color: {color}");
    }
}

// Flyweight Factory Class
public class ShapeFactory
{
    private readonly Dictionary<string, IShape> _shapes = new();

    public IShape GetShape(string shapeType)
    {
        if (!_shapes.ContainsKey(shapeType))
        {
            // Create and store new flyweight instance if it doesn't exist
            switch (shapeType)
            {
                case "Circle":
                    _shapes[shapeType] = new Circle();
                    break;
                default:
                    throw new ArgumentException("Invalid shape type.");
            }
        }

        return _shapes[shapeType]; // Return shared instance
    }

    public int TotalShapesCreated() => _shapes.Count; // Utility method for debugging
}

// Client Code
class Program
{
    static void Main(string[] args)
    {
        var factory = new ShapeFactory();

        // Request flyweight instances
        IShape circle1 = factory.GetShape("Circle");
        circle1.Draw("Red"); // Extrinsic state: "Red"

        IShape circle2 = factory.GetShape("Circle");
        circle2.Draw("Blue"); // Extrinsic state: "Blue"

        IShape circle3 = factory.GetShape("Circle");
        circle3.Draw("Green"); // Extrinsic state: "Green"

        // Verify that only one Circle instance was created
        Console.WriteLine($"Total shapes created: {factory.TotalShapesCreated()}");
    }
}

/*
Code Explanation
Flyweight Interface (IShape):
Defines a contract for flyweight objects.
Includes a method Draw(string color) that uses the extrinsic state (e.g., color).

Concrete Flyweight Class (Circle):
Implements the IShape interface.
Maintains intrinsic state (_shapeType), which is invariant and shared across instances.
Uses the extrinsic state (color) provided by the client to perform operations.

Flyweight Factory (ShapeFactory):
Manages a pool of flyweight objects (_shapes dictionary).
Ensures that shared objects are reused and not duplicated.
Provides utility methods like TotalShapesCreated() for debugging.

Client Code:
Requests flyweight instances from the ShapeFactory.
Passes extrinsic state (e.g., color) to the flyweight objects during operations.
Demonstrates how multiple operations can reuse the same shared object.

Memory Efficiency:
Instead of creating a new Circle instance for each Draw() call, the factory reuses a single instance, minimizing memory usage.
*/