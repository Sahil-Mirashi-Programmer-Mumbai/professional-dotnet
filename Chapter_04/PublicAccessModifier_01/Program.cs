// Program to demonstrate Public Access Modifier in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace PublicAccessModifier_01
{
    class Car
    {
        // public field accessible from anywhere in the program
        public string Model;

        // public method accessible from anywhere in the program
        public void DisplayCar()
        {
            Console.WriteLine($"Model: {Model}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Public Access Modifier in C# with Visual Studio\n");

            Car car = new Car();
            car.Model = "BMW"; // Accessing public field
            car.DisplayCar(); // Output: Model: BMW
        }
    }
}
