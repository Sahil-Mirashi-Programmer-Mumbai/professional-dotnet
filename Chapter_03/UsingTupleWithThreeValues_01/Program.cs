// Program to demonstrate Using Tuple with Three Values in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace UsingTupleWithThreeValues_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Using Tuple with Three Values in C# with Visual Studio\n");

            // Creating a Tuple with three values: int, string, and double.
            Tuple<int, string, double> student = new Tuple<int, string, double>(1, "Tom", 80.75);

            // Accessing the three elements of the tuple.
            Console.WriteLine($"Student ID: {student.Item1}"); // Output: Student ID: 1
            Console.WriteLine($"Student Name: {student.Item2}"); // Output: Student Name: Tom
            Console.WriteLine($"Student Percentage: {student.Item3}"); // Output: Student Percentage: 80.75
        }
    }
}
