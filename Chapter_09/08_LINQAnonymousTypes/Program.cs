/*
Program to demonstrate LINQ Anonymous Types in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: Anonymous types allow creating temporary data structures on-the-fly.
Application: Transforming data for specific needs in queries.
*/

namespace LINQAnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate LINQ Anonymous Types in C# with Visual Studio\n");

            // List of employees
            var employees = new List<dynamic>
            {
                new { Name = "Alice", Department = "HR" },
                new { Name = "Bob", Department = "IT" },
                new { Name = "Charlie", Department = "HR" }
            };

            // Filtering employees from HR department
            var hrEmployees = from emp in employees
                              where emp.Department == "HR"
                              select emp;

            // Displaying results
            Console.WriteLine("HR Employees:");
            foreach (var emp in hrEmployees)
            {
                Console.WriteLine(emp.Name);
            }
        }
    }
}