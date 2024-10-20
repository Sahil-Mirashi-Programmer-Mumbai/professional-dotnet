// Program to demonstrate using protected members in C# with Visual Studio
// Programmer: Sahil Mirashi

// Creating the parent/base class "Appliance"
public class Appliance
{
    protected string brand;

    // Implementation of constructor
    public Appliance(string brandName)
    {
        brand = brandName;
    }
}

public class WashingMachine : Appliance
{
    // Calling the parent/base class constructor
    public WashingMachine(string brandName) : base(brandName) { }

    // Implementation of ShowBrand() method in the child class "WashingMachine"
    public void ShowBrand()
    {
        Console.WriteLine($"Brand name is {brand} (Child class method implementation)");
    }
}

namespace UsingProtectedMembers_01
{

    public class Program
    {
        // Creating the Main() function where the application starts
        static void Main()
        {
            Console.WriteLine("Program to demonstrate using protected members in C# with Visual Studio\n");

            // Creating the washingMachineObject object using the "WashingMachine" class 
            WashingMachine washingMachineObject = new WashingMachine("LG");

            // Calling the ShowBrand() method of the washingMachineObject
            washingMachineObject.ShowBrand();
        }
    }
}