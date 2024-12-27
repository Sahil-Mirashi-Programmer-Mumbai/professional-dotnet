/*
Definition:
The Prototype Pattern creates new objects by cloning existing ones. 
It avoids the cost of creating objects from scratch when the initialization process is resource-intensive.

Applications:
When object creation is expensive, such as in simulations or when large datasets are involved.
When creating objects dynamically during runtime.
*/

namespace PrototypePatternExample
{
    // Prototype interface
    public interface IPrototype
    {
        IPrototype Clone();
    }

    // Concrete Prototype
    public class Employee : IPrototype
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public Employee(string name, string position)
        {
            Name = name;
            Position = position;
        }

        // Clone method
        public IPrototype Clone()
        {
            return (IPrototype)MemberwiseClone();
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Name: {Name}, Position: {Position}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create original object
            Employee originalEmployee = new Employee("John Doe", "Manager");
            originalEmployee.ShowDetails();

            // Clone the object
            Employee clonedEmployee = (Employee)originalEmployee.Clone();
            clonedEmployee.Name = "Jane Smith"; // Modify cloned object

            // Display details of both objects
            Console.WriteLine("\nOriginal Employee:");
            originalEmployee.ShowDetails();
            Console.WriteLine("\nCloned Employee:");
            clonedEmployee.ShowDetails();

            Console.ReadLine();
        }
    }
}

/*
Explanation of Code:
Prototype Interface(IPrototype):
Declares the Clone method for creating duplicates.

Concrete Prototype (Employee):
Implements the Clone method using MemberwiseClone, which performs a shallow copy.

Main Method:
Creates an object, clones it, and demonstrates that modifications to the clone do not affect the original.
*/