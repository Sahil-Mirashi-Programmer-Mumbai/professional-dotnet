/*
Definition:
Factory pattern defines interface for creating object but allows subclass to alter type of object.

Why it is used:
To centralize object creation, allowing for more flexibility and decoupling of classes.
*/

namespace FactoryPattern
{
    // Abstract product
    public abstract class Animal
    {
        public abstract void Speak();
    }

    // Concrete product
    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Woof!");
        }
    }

    // Concrete product
    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Meow!");
        }
    }

    // Factory class
    public class AnimalFactory
    {
        public static Animal GetAnimal(string animalType)
        {
            if (animalType.Equals("Dog"))
                return new Dog();
            else if (animalType.Equals("Cat"))
                return new Cat();
            else
                throw new ArgumentException("Invalid animal type");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = AnimalFactory.GetAnimal("Dog");
            dog.Speak();  // Output: Woof!

            Animal cat = AnimalFactory.GetAnimal("Cat");
            cat.Speak();  // Output: Meow!
        }
    }
}