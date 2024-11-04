// Program to demonstrate Access Modifiers In Properties in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace AccessModifiersInProperties_01
{
    class Person
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }

            // Public property with private setter
            private set
            {
                name = value;
            }
        }

        public Person(string personName)
        {
            Name = personName;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Access Modifiers In Properties in C# with Visual Studio\n");

            Person person = new Person("Tom");
            Console.WriteLine($"Name: {person.Name}"); // Output: Name: Tom
        }
    }
}
