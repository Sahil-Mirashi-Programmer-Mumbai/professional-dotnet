/*
Program to demonstrate Multi-level Dictionary in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: Multi-level dictionaries allow for hierarchical data storage.
Application: Storing structured data like courses and their students, departments, etc.
*/

namespace MultiLevelDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Multi-level Dictionary in C# with Visual Studio\n");

            // Multi-level Dictionary to store courses and enrolled students
            Dictionary<string, Dictionary<int, string>> courseStudents = new Dictionary<string, Dictionary<int, string>>();

            // Adding nested data
            courseStudents["Math"] = new Dictionary<int, string>
            {
                { 1, "Alice" },
                { 2, "Bob" }
            };
            courseStudents["Science"] = new Dictionary<int, string>
            {
                { 3, "Charlie" },
                { 4, "David" }
            };

            // Accessing nested data
            foreach (var course in courseStudents)
            {
                Console.WriteLine($"Course: {course.Key}");
                foreach (var student in course.Value)
                {
                    Console.WriteLine($"  ID: {student.Key}, Name: {student.Value}");
                }
            }
        }
    }
}