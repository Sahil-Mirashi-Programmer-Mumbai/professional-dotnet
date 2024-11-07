// Program to demonstrate Returning Tuple from Method in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace ReturningTupleFromMethod_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Returning Tuple from Method in C# with Visual Studio\n");

            // Call the GetEmployeeData method which returns a Tuple with ID and Name
            var employee = GetEmployeeData();

            Console.WriteLine($"ID: {employee.Item1}"); // Output: ID: 101
            Console.WriteLine($"Name: {employee.Item2}"); // Output: Name: Tom
        }

        // Method that returns a Tuple containing an int and a string.
        static Tuple<int, string> GetEmployeeData()
        {
            return new Tuple<int, string>(101, "Tom"); // return tuple object with ID and Name
        }
    }
}
