// Program to demonstrate Private Protected Access Modifier In Inheritance in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace PrivateProtectedAccessModifierInInheritance_01
{
    class Shape
    {
        // Private protected field accessible in derived class 'Circle' within the same assembly
        private protected string shape = "Shape";

        // Private protected method
        private protected void DisplayShape()
        {
            Console.WriteLine($"This is a {shape}");
        }
    }

    class Square : Shape
    {
        public void ShowShape()
        {
            shape = "Square"; // Accessing private protected field in derived class
            DisplayShape(); // Accessing private protected method in derived class
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Private Protected Access Modifier In Inheritance in C# with Visual Studio\n");

            Square square = new Square();
            square.ShowShape(); // Output: This is a Square
        }
    }
}
