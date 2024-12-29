/*
Facade Design Pattern

Definition:
The Facade Pattern provides a simplified interface to a larger body of code, making a complex subsystem easier to use.
It is used to shield clients from the complexity of subsystems by providing a unified interface.

When to Use:
Use this pattern when:
1. You need to provide a simple interface to a complex subsystem.
2. You want to decouple clients from the subsystem components, improving maintainability and scalability.
Example: Simplifying access to a complex library for a payment gateway by providing a single interface for initialization, processing, and closing transactions.
*/

// Step 1: Define subsystem classes with complex behaviors
class SubsystemA
{
    public void OperationA()
    {
        // SubsystemA specific operation
        Console.WriteLine("SubsystemA: OperationA executed.");
    }
}

class SubsystemB
{
    public void OperationB()
    {
        // SubsystemB specific operation
        Console.WriteLine("SubsystemB: OperationB executed.");
    }
}

class SubsystemC
{
    public void OperationC()
    {
        // SubsystemC specific operation
        Console.WriteLine("SubsystemC: OperationC executed.");
    }
}

// Step 2: Define the Facade class
class Facade
{
    private SubsystemA subsystemA;
    private SubsystemB subsystemB;
    private SubsystemC subsystemC;

    public Facade()
    {
        // Initialize the subsystems
        subsystemA = new SubsystemA();
        subsystemB = new SubsystemB();
        subsystemC = new SubsystemC();
    }

    public void Operation1()
    {
        Console.WriteLine("Facade: Coordinating Subsystems for Operation1");
        subsystemA.OperationA();
        subsystemB.OperationB();
    }

    public void Operation2()
    {
        Console.WriteLine("Facade: Coordinating Subsystems for Operation2");
        subsystemC.OperationC();
    }
}

// Step 3: Client Code
class FacadeExample
{
    static void Main(string[] args)
    {
        // Use the Facade to simplify interactions with subsystems
        Facade facade = new Facade();

        // Perform high-level operations through the Facade
        facade.Operation1();
        facade.Operation2();

        Console.ReadLine();
    }
}

/*
Explanation:
- Subsystems(SubsystemA, SubsystemB, SubsystemC) define the detailed operations.
- The Facade class provides a simplified interface to access these subsystems.
- The client interacts with the subsystems indirectly through the Facade, hiding complexity and improving usability.
*/