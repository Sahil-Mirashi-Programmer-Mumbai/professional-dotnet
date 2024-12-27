/*
Program to demonstrate LINQ Select Properties in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: LINQ can extract specific properties using "select".
Application: Preparing datasets for dropdowns or other UI elements.
*/

namespace LINQSelectProperties
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate LINQ Select Properties in C# with Visual Studio\n");

            // List of students
            List<Student> students = new List<Student>
            {
                new Student { Name = "Alice", Age = 20 },
                new Student { Name = "Bob", Age = 22 },
                new Student { Name = "Charlie", Age = 19 }
            };

            // Selecting only names of students
            var studentNames = from student in students
                               select student.Name;

            // Displaying student names
            Console.WriteLine("Student Names:");
            foreach (var name in studentNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}