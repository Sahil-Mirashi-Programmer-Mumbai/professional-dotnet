// Program to demonstrate using Tuples as Method Parameters in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace UsingTuplesAsMethodParameters_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate using Tuples as Method Parameters in C# with Visual Studio\n");

            // Create a tuple using implicit type inference to hold student data
            (int Id, string Name, double Grade) student = (1, "Tom", 70);

            // Pass the tuple as a parameter to the DisplayStudentInfo method.
            DisplayStudentInfo(student);
        }

        // Method that accepts a tuple parameter.
        static void DisplayStudentInfo((int Id, string Name, double Grade) student)
        {
            Console.WriteLine($"Student ID: {student.Id}"); // Output: Student ID: 1
            Console.WriteLine($"Student Name: {student.Name}"); // Output: Student Name: Tom
            Console.WriteLine($"Student Grade: {student.Grade}"); // Output: Student Grade: 70
        }
    }
}
