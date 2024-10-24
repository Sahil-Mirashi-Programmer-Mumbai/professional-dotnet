// Program to demonstrate method overriding in C# with Visual Studio
// Programmer: Sahil Mirashi

public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The dog barks.");
    }
}

namespace MethodOverriding_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate method overriding in C# with Visual Studio\n");

            Animal myAnimal = new Animal();
            Animal myDog = new Dog();  // Upcasting

            myAnimal.Speak();  // Output: The animal makes a sound.
            myDog.Speak();     // Output: The dog barks. (Runtime polymorphism)
        }
    }
}
