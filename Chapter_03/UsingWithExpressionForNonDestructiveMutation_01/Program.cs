// Program to demonstrate Using with Expression for Non Destructive Mutation in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace UsingWithExpressionForNonDestructiveMutation_01
{
    // Creating an initial instance of 'Student' record.
    record Student(string Name, string Department);

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Using with Expression for Non Destructive Mutation in C# with Visual Studio\n");

            // Creating an initial instance of 'Student' record.
            Student student_1 = new Student("Tom", "Computer");

            // Using the 'with' expression to create a new record based on 'student_1' but with a different department.
            Student student_2 = student_1 with { Department = "Information Technology" };

            // Displaying details of both students.
            Console.WriteLine(student_1); // Output: Student { Name = Tom, Department = Computer }
            Console.WriteLine(student_2); // Output: Student { Name = Tom, Department = Information Technology }
        }
    }
}
