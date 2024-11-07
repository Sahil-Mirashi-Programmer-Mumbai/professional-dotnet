// Program to demonstrate Comparing Record Instances in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace ComparingRecordInstances_01
{
    // A record named 'Employee' that holds information about a employee.
    // Records automatically provide value-based equality checks.
    record Employee(string firstName, string lastName);

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Comparing Record Instances in C# with Visual Studio\n");

            // Creating two instances of 'Employee' record with the same values.
            Employee employee_1 = new Employee("Harry", "John");
            Employee employee_2 = new Employee("Harry", "John");

            // Using the equality operator (==) to check if both instances are equal.
            // Since records use value-based equality, this will return true.
            Console.WriteLine($"{employee_1 == employee_2}"); // Output: true
        }
    }
}
