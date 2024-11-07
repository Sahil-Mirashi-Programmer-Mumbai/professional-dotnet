// Program to demonstrate Creating Basic Tuple in C# with Visual Studio
// Programmer: Sahil Mirashi
/*
    Tuples provide a way to store multiple values together without needing to create a custom type (like a class or struct).
    Each value within a tuple can be of a different data type, making tuples helpful for grouping and returning multiple results
    from methods without the overhead of custom classes.
*/
namespace CreatingBasicTuple_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Creating Basic Tuple in C# with Visual Studio\n");

            // Creating a Tuple to hold two values, both an integer and a string.
            Tuple<int, string> person = new Tuple<int, string>(1, "Tom");

            // Accessing Tuple elements by Item1 and Item2 properties.
            Console.WriteLine($"ID: {person.Item1} Name: {person.Item2}");
        }
    }
}
