// Program to demonstrate Inheriting from Record in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace InheritingFromRecord_01
{
    // Base record 'Employee' with properties 'Name' and 'Salary'.
    // Records can serve as base types for other records, allowing inheritance.
    record Employee(string Name, decimal Salary);

    // Derived record 'Manager' inherits from 'Employee' and adds a new property 'Department'.
    // This demonstrates how records can be extended to include additional data.
    record Manager(string Name, string Department, decimal Salary) : Employee(Name, Salary);

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Inheriting from Record in C# with Visual Studio\n");

            // Creating an instance of 'Employee' record.
            Employee employee = new Employee("Tom", 50000);

            // Creating an instance of 'Manager' record, which inherits from 'Employee'.
            Manager manager = new Manager("Mike", "Sales", 100000);

            // Displaying details of employee and manager.
            Console.WriteLine(employee);
            Console.WriteLine(manager);
        }
    }
}
