// Program to demonstrate Nested Tuples for Complex Data in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace NestedTuplesForComplexData_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Nested Tuples for Complex Data in C# with Visual Studio\n");

            // Nested tuple for complex data representation
            var department = (Id: 1, Name: "Sales", Manager: (Id: 101, Name: "Mike"));

            // Accessing elements from the nested tuple
            Console.WriteLine($"Department ID: {department.Id}"); // Output: Department ID: 1
            Console.WriteLine($"Department Name: {department.Name}"); // Output: Department Name: Sales
            Console.WriteLine($"Manager ID: {department.Manager.Id}"); // Output: Manager ID: 101
            Console.WriteLine($"Manager Name: {department.Manager.Name}"); // Output: Manager Name: Mike
        }
    }
}
