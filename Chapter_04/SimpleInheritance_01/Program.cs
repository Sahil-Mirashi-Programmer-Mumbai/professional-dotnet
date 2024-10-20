// Program to demonstrate simple inheritance in C# with Visual Studio
// Programmer: Sahil Mirashi

// Creating the parent/base class "Animal"
public class Animal
{
    // Implementation of Eat() method in the parent class "Animal"
    public void Eat()
    {
        Console.WriteLine("Animal eats (Parent class method implementation)");
    }
}

// Creating the child/derived class "Dog"
public class Dog : Animal
{
    // Implementation of Bark() method in the child class "Dog"
    public void Bark()
    {
        Console.WriteLine("Dog barks (Child class method implementation)");
    }
}

namespace SimpleInheritance_01
{

    public class Program
    {
        // Creating the Main() function where the application starts
        static void Main()
        {
            Console.WriteLine("Program to demonstrate simple inheritance in C# with Visual Studio\n");

            // Creating the dogObject object using the "Dog" class 
            Dog dogObject = new Dog();

            // Calling the Eat() method inherited from the parent class of dogObject
            dogObject.Eat();

            // Calling the Bark() method of the dogObject
            dogObject.Bark();
        }
    }
}