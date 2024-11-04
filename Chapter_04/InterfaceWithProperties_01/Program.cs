// Program to demonstrate Interface With Properties in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace InterfaceWithProperties_01
{
    // Interface with property
    interface IVehicle
    {
        int Speed { get; set; } // Property to get and set speed

        void Drive();
    }

    class Car : IVehicle
    {
        public int Speed {  set; get; } // Implementing property

        public void Drive()
        {
            Console.WriteLine($"Car is driving at {Speed} km/hr");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Interface With Properties in C# with Visual Studio\n");

            Car car = new Car();
            car.Speed = 200;
            car.Drive();
        }
    }
}
