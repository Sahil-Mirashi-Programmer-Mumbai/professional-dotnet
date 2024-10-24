// Program to demonstrate interfaces and polymorphism in C# with Visual Studio
// Programmer: Sahil Mirashi

public interface IMovable
{
    void Move();
}

public class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("The car drives on the road");
    }
}

public class Plane : IMovable
{
    public void Move()
    {
        Console.WriteLine("The plane files in the sky");
    }
}


namespace InterfacesAndPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate interfaces and polymorphism in C# with Visual Studio\n");

            IMovable[] movables = { new Car(), new Plane() };

            foreach (IMovable movable in movables)
            {
                movable.Move();
            }
        }
    }
}
