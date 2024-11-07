// Program to demonstrate Named Tuples using Value Tuple in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace NamedTuplesUsingValueTuple_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Named Tuples using Value Tuple in C# with Visual Studio\n");

            // Create a ValueTuple with named elements for better readability.
            (int Id, string Name, decimal Salary) employee = new(1, "Tom", 50000);

            // Access Tuple elements by name.
            Console.WriteLine($"ID: {employee.Id} Name: {employee.Name} Salary: {employee.Salary}"); // Output: ID: 1 Name: Tom Salary: 50000
        }
    }
}
