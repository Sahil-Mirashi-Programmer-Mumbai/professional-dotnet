// Program to demonstrate Protected Internal Access Modifier With Multiple Assemblies in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace ProtectedInternalAccessModifierWithMultipleAssemblies_01
{
    class Vehicle
    {
        // Protected internal accessible in derived call or within the same assembly
        protected internal string model = "Model";

        // Protected internal method
        protected internal void DisplayModel()
        {
            Console.WriteLine($"Model: {model}");
        }
    }

    class Car : Vehicle
    {
        public void ShowCar()
        {
            // Accessing protected internal field and method in derived class
            model = "Civic";
            DisplayModel();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Protected Internal Access Modifier With Multiple Assemblies in C# with Visual Studio\n");

            Car car = new Car();
            car.ShowCar(); // Output: Model: Civic
        }
    }
}
