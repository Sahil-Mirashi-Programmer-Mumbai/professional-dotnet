// Program to demonstrate Protected Access Modifier And Inheritance in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace ProtectedAccessModifierAndInheritance_01
{
    public class Animal
    {
        // Protected field sound accessible within the base class 'Animal' and derived class 'Dog'
        protected string sound = "Some sound";

        // Protected method
        protected void MakeSound()
        {
            Console.WriteLine($"Animal Sound: {sound}");
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            // Accessing protected field and method from the base class 'Animal'
            sound = "Bark";
            MakeSound();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Protected Access Modifier And Inheritance in C# with Visual Studio\n");

            Dog dog = new Dog();
            dog.Bark(); // Output: Animal Sound: Bark
        }
    }
}
