// Program to demonstrate abstract classes and polymorphism in C# with Visual Studio
// Programmer: Sahil Mirashi

public abstract class Employee
{
    public string Name { get; set; }
    public Employee(string name)
    {
        Name = name;
    }

    public abstract void DisplaySalary();
}

public class FullTimeEmployee : Employee
{
    public FullTimeEmployee(string name) : base(name) { }

    public override void DisplaySalary()
    {
        Console.WriteLine($"{Name} gets a fixed salary");
    }
}

public class PartTimeEmployee : Employee
{
    public PartTimeEmployee(string name) : base(name) { }

    public override void DisplaySalary()
    {
        Console.WriteLine($"{Name} gets paid by the hour");
    }
}

namespace AbstractClassesAndPolymorphism_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate abstract classes and polymorphism in C# with Visual Studio");

            Employee[] employees = { new FullTimeEmployee("Tom"), new PartTimeEmployee("Jerry")};

            foreach(Employee employee in employees)
            {
                employee.DisplaySalary();
            }
        }
    }
}
