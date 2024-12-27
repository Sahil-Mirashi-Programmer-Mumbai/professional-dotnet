/*
Program to demonstrate LINQ With EF Core in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: LINQ integrates with Entity Framework Core for querying relational databases.
Application: Simplifying complex database queries with strong typing.
*/

using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace LINQWithEFCore
{
    // Entity model for Students
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    // DbContext for managing database
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("SchoolDB");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate LINQ With EF Core in C# with Visual Studio\n");

            using (var context = new SchoolContext())
            {
                // Adding sample students to the database
                context.Students.AddRange(
                    new Student { Name = "Alice", Age = 20 },
                    new Student { Name = "Bob", Age = 22 });
                context.SaveChanges();

                // Using LINQ to query students older than 21
                var adultStudents = context.Students.Where(s => s.Age > 21);

                Console.WriteLine("Adult Students:");
                foreach (var student in adultStudents)
                {
                    Console.WriteLine(student.Name);
                }
            }
        }
    }
}