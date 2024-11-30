/*
Program to demonstrate Nested Dictionary Manipulation in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: Multi - level data manipulation supports complex hierarchical structures.
Application: Employee management systems, organizational charts, etc.
*/

namespace NestedDictionaryManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Nested Dictionary Manipulation in C# with Visual Studio\n");

            // Multi-level Dictionary: Company Departments -> Employees
            Dictionary<string, Dictionary<int, string>> company = new Dictionary<string, Dictionary<int, string>>
            {
                {
                    "HR", new Dictionary<int, string>
                    {
                        { 101, "Alice" },
                        { 102, "Bob" }
                    }
                },
                {
                    "IT", new Dictionary<int, string>
                    {
                        { 201, "Charlie" },
                        { 202, "David" }
                    }
                }
            };

            // Add a new employee to IT
            company["IT"].Add(203, "Eve");

            // Remove an employee from HR
            company["HR"].Remove(102);

            // Display updated data
            foreach (var department in company)
            {
                Console.WriteLine($"Department: {department.Key}");
                foreach (var employee in department.Value)
                {
                    Console.WriteLine($"  ID: {employee.Key}, Name: {employee.Value}");
                }
            }
        }
    }
}