// Program to demonstrate Basic Interface Definition And Implementation in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace BasicInterfaceDefinitionAndImplementation_01
{
    interface IShape
    {
        // Interface members are public and abstract by default
        double CalculateArea();
    }

    // Implementing the IShape interface in a class 'Circle'
    class Circle: IShape
    {
        private double radius;
        
        // Constructor to initialize radius
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Implementing the CalculateArea method from IShape interface
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Basic Interface Definition And Implementation in C# with Visual Studio\n");

            Circle circle = new Circle(5);
            Console.WriteLine($"Area: {circle.CalculateArea():F2}"); // Output: Area: 78.54
        }
    }
}