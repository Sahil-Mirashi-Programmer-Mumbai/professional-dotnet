// Program to demonstrate inheritance with constructor in C# with Visual Studio
// Programmer: Sahil Mirashi

// Creating the parent/base class "Vehicle"
public class Vehicle
{
    public string Brand;

    // Implementation of constructor in the parent class "Vehicle"
    public Vehicle(string brand)
    {
        Brand = brand;
    }

    // Implementation of ShowBrand() method in the parent class "Vehicle"
    public void ShowBrand()
    {
        Console.WriteLine($"Car brand: {Brand} (Parent class method implementation)");
    }
}

// Creating the child/derived class "Car"
public class Car : Vehicle
{
    // Calling the parent/base class constructor using base keyword
    public Car(string brand) : base(brand)
    {
        // Empty constructor implementation
    }
}

namespace InheritanceWithConstructor_01
{

    public class Program
    {
        // Creating the Main() function where the application starts
        static void Main()
        {
            Console.WriteLine("Program to demonstrate inheritance with constructor in C# with Visual Studio\n");

            // Creating the carObject object using the "Car" class
            Car carObject = new Car("BMW");

            // Calling the ShowBrand() method of the child class carObject implemented in the parent class "Vehicle"
            carObject.ShowBrand();
        }
    }
}