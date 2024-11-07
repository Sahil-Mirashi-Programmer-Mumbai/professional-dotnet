// Program to demonstrate Basic Record Declaration in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace BasicRecordDeclaration_01
{
    // Declaring a simple record named 'Person'.
    // A record is a reference type that provides a way to encapsulate data.
    // Records are immutable by default, meaning their values cannot be changed once assigned.
    record Person(string Name, int Age);

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Basic Record Declaration in C# with Visual Studio\n");

            // Creating an instance of the 'Person' record.
            Person person = new("Tom", 21);

            // Displaying the properties of the record.
            Console.WriteLine($"Name: {person.Name} Age: {person.Age}"); // Output: Name: Tom Age: 21
        }
    }
}
