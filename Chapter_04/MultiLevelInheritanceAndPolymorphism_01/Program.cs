// Program to demonstrate multi-level inheritance and polymorphism in C# with Visual Studio
// Programmer: Sahil Mirashi

// Creating the parent/base class "Animal"
public class Animal
{
    // Implementation of Move() virtual method in the parent class "Animal"
    public virtual void Move()
    {
        Console.WriteLine("The animal moves (Parent class method implementation)");
    }
}

// Creating the child/derived class "Bird"
public class Bird : Animal
{
    // Override the Move() method to provide a specific implementation for Bird
    public override void Move()
    {
        Console.WriteLine("The bird flies (Child class method implementation)");
    }
}

// Creating the child/derived class "Penguin"
public class Penguin : Bird
{
    // Override the Move() method to provide a specific implementation for Penguin
    public override void Move()
    {
        Console.WriteLine("The penguin swims (Child class method implementation)");
    }
}

namespace MultiLevelInheritanceAndPolymorphsim_01
{
    public class Program
    {
        // Creating the Main() function where the application starts
        static void Main()
        {
            Console.WriteLine("Program to demonstrate multi-level inheritance and polymorphism in C# with Visual Studio\n");

            // Creating the animalObject object using the "Animal" class
            Animal animalObject = new Animal();

            // Creating the birdObject object using the "Bird" class
            Bird birdObject = new Bird();

            // Creating the penguinObject object using the "Penguin" class
            Penguin penguinObject = new Penguin();

            // Calling the Move() method of the animalObject
            animalObject.Move();

            // Calling the Move() method of the birdObject
            birdObject.Move();

            // Calling the Move() method of the penguinObject
            penguinObject.Move();
        }
    }
}