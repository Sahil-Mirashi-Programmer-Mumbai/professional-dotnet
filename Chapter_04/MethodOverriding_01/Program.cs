// Program to demonstrate method overriding in C# with Visual Studio
// Programmer: Sahil Mirashi

// Creating the parent/base class "Animal"
public class Animal
{
    // Implementation of Sound() virtual method in the parent class "Animal"
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes sound (Parent class method implementation)");
    }
}

// Creating the child/derived class "Cat"
public class Cat : Animal
{
    // Override the Sound() method to provide a specific implementation for Cat
    public override void Sound()
    {
        Console.WriteLine("Cat says meow (Child class method implementation)");
    }
}

namespace MethodOverriding_01
{
    public class Program
    {
        // Creating the Main() function where the application starts
        static void Main()
        {
            Console.WriteLine("Program to demonstrate method overriding in C# with Visual Studio\n");

            // Creating the animalObject object using the "Animal" class 
            Animal animalObject = new Animal();

            // Creating the catObject object using the "Cat" class 
            Cat catObject = new Cat();

            // Calling the Sound() method of the animalObject
            animalObject.Sound();

            // Calling the Sound() method of the catObject
            catObject.Sound();
        }
    }
}
