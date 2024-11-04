// Program to demonstrate Interface As Parameter in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace InterfaceAsParameter_01
{
    interface IMovable
    {
        void Move();
    }

    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    class Plane: IMovable
    {
        public void Move()
        {
            Console.WriteLine("Plane is moving");
        }
    }

    internal class Program
    {
        // Method that accepts 'IMovable' interface as a parameter
        static void StartMoving(IMovable movable)
        {
            movable.Move();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Interface As Parameter in C# with Visual Studio\n");

            Car car = new Car();
            Plane plane = new Plane();

            StartMoving(car);
            StartMoving(plane);
        }
    }
}
