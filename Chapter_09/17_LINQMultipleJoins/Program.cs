/*
Program to demonstrate LINQ Multiple Joins in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: LINQ can handle multiple joins across data collections with clear syntax.
Application: Combining multiple datasets for comprehensive reporting.
*/

namespace LINQMultipleJoins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate LINQ Multiple Joins in C# with Visual Studio\n");

            // Employee and Department data
            var employees = new[]
            {
                new { Id = 1, Name = "Alice", DepartmentId = 1 },
                new { Id = 2, Name = "Bob", DepartmentId = 2 }
            };

            var departments = new[]
            {
                new { Id = 1, Name = "HR" },
                new { Id = 2, Name = "IT" }
            };

            var salaries = new[]
            {
                new { EmployeeId = 1, Amount = 50000 },
                new { EmployeeId = 2, Amount = 60000 }
            };

            // Performing joins using LINQ
            var employeeDetails = from emp in employees
                                  join dept in departments on emp.DepartmentId equals dept.Id
                                  join sal in salaries on emp.Id equals sal.EmployeeId
                                  select new { emp.Name, dept.Name, sal.Amount };

            Console.WriteLine("Employee Details:");
            foreach (var detail in employeeDetails)
            {
                Console.WriteLine($"{detail.Name} - {detail.Name} - ${detail.Amount}");
            }
        }
    }
}