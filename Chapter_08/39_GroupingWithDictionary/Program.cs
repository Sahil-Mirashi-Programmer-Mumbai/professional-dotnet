/*
Program to demonstrate Grouping with Dictionary in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: Dictionaries can organize data into groups, making them useful for categorization tasks.
Application: Grouping products, students, or data points for reports or analysis.
*/

namespace GroupingWithDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Grouping with Dictionary in C# with Visual Studio\n");

            // List of students and their grades
            List<(string Name, string Grade)> students = new List<(string, string)>
            {
                ("Alice", "A"), ("Bob", "B"), ("Charlie", "A"), ("David", "C"), ("Eva", "B")
            };

            // Creating a Dictionary to group students by their grades
            Dictionary<string, List<string>> gradeGroups = new Dictionary<string, List<string>>();

            foreach (var student in students)
            {
                if (!gradeGroups.ContainsKey(student.Grade))
                {
                    // Initialize a new list if the grade is not already a key
                    gradeGroups[student.Grade] = new List<string>();
                }

                // Add the student's name to the respective grade group
                gradeGroups[student.Grade].Add(student.Name);
            }

            // Displaying grouped data
            foreach (var group in gradeGroups)
            {
                Console.WriteLine($"Grade: {group.Key}");
                foreach (var student in group.Value)
                {
                    Console.WriteLine($"  {student}");
                }
            }
        }
    }
}