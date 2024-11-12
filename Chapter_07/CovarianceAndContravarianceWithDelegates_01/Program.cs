// Program to demonstrate covariance and contravariance with delegates in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Covariance allows derived type to be used with delegates expecting a base type
    Application: Enhance flexibility with polymorphic methods
*/

namespace CovarianceAndContravarianceWithDelegates_01
{
    // Base class
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal Speaks");
        }
    }

    // Derived class
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog Barks");
        }
    }

    // Covariance delegate returning an Animal
    public delegate Animal AnimalFactory();

    internal class Program
    {

        public static Dog CreateDog()
        {
            return new Dog();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate covariance and contravariance with delegates in C# with Visual Studio\n");

            // Covariance allows assigning a method returning Dog to delegate expecting Animal
            AnimalFactory animalFactory = CreateDog;
            Animal animal = animalFactory();
            animal.Speak(); // Output: Dog Barks
        }
    }
}
