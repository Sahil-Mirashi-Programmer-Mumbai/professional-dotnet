/*
Decorator Design Pattern

Definition:
The Decorator Pattern allows behavior to be added to an individual object, dynamically, 
without affecting the behavior of other objects from the same class.

It is used to adhere to the Single Responsibility Principle by dividing functionality between classes with unique areas of concern.

When to Use:
Use this pattern when:
1. You want to add responsibilities to individual objects dynamically and transparently.
2. Extending functionality by subclassing is impractical or leads to an explosion of subclasses.

Example: Adding features like scrollbars, borders, or shadows to UI components dynamically.
*/

// Step 1: Define the Component interface or abstract class
abstract class Component
{
    public abstract void Operation();
}

// Step 2: Concrete Component implements the Component interface or abstract class
class ConcreteComponent : Component
{
    public override void Operation()
    {
        // Base behavior of the component
        Console.WriteLine("Concrete Component Operation");
    }
}

// Step 3: Define the Decorator abstract class, inheriting from Component
abstract class Decorator : Component
{
    protected Component component;

    public Decorator(Component component)
    {
        // Initialize the component to be decorated
        this.component = component;
    }

    public override void Operation()
    {
        // Forward the request to the component
        component.Operation();
    }
}

// Step 4: Concrete Decorators extend the functionality of the component
class ConcreteDecoratorA : Decorator
{
    public ConcreteDecoratorA(Component component) : base(component)
    {
    }

    public override void Operation()
    {
        base.Operation();
        // Additional behavior for Decorator A
        Console.WriteLine("Concrete Decorator A Added Operation");
    }
}

class ConcreteDecoratorB : Decorator
{
    public ConcreteDecoratorB(Component component) : base(component)
    {
    }

    public override void Operation()
    {
        base.Operation();
        // Additional behavior for Decorator B
        Console.WriteLine("Concrete Decorator B Added Operation");
    }
}

// Step 5: Client Code
class DecoratorExample
{
    static void Main(string[] args)
    {
        // Create a ConcreteComponent instance
        Component concreteComponent = new ConcreteComponent();

        // Wrap the component with ConcreteDecoratorA
        Component decoratorA = new ConcreteDecoratorA(concreteComponent);

        // Further wrap it with ConcreteDecoratorB
        Component decoratorB = new ConcreteDecoratorB(decoratorA);

        // Execute the operations
        decoratorB.Operation();

        Console.ReadLine();
    }
}

/*
Explanation:
- ConcreteComponent defines the core functionality.
- Decorators (ConcreteDecoratorA and ConcreteDecoratorB) add additional responsibilities to the component dynamically.
- The client code can layer decorators as needed, extending behavior without modifying the underlying component or its existing decorators.
*/