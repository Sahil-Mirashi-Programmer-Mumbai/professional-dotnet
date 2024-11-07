// Program to demonstrate Tuple in Collection in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace TupleInCollection_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Tuple in Collection in C# with Visual Studio\n");

            // Create a list of tuples to hold employee data.
            List<(int Id, string Name)> employees = new List<(int Id, string Name)>
            {
                (1, "Tom"),
                (2, "Mike"),
                (3, "John")
            };

            // Iterate through each tuple in the list and print the details.
            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee ID: {employee.Id} Employee Name: {employee.Name}");
            }
        }
    }
}
