/*
Definition: Decorator Pattern allows you to dynamically add behavior to an object at runtime without affecting the behavior of other objects from the same class.

Why it is used: To add new responsibilities to an object, and extend its behavior without modifying its structure.

Applications of the Decorator Pattern:
Used in graphical user interface (GUI) libraries for adding behaviors like scrollbars, borders, or tooltips to UI components.
Extending functionalities in logging frameworks or I/O streams.
Dynamic extension of classes in scenarios where subclassing is impractical.
*/

// Step 1: Define the Component Interface
public interface ICoffee
{
    double GetCost(); // Method to get the cost of the coffee
    string GetDescription(); // Method to get the description of the coffee
}

// Step 2: Concrete Component (Basic Coffee)
public class SimpleCoffee : ICoffee
{
    public double GetCost()
    {
        return 50; // Cost of plain coffee
    }

    public string GetDescription()
    {
        return "Simple Coffee";
    }
}

// Step 3: Abstract Decorator Class
public abstract class CoffeeDecorator : ICoffee
{
    protected ICoffee _coffee; // Reference to the Component being decorated

    public CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public virtual double GetCost()
    {
        return _coffee.GetCost();
    }

    public virtual string GetDescription()
    {
        return _coffee.GetDescription();
    }
}

// Step 4: Concrete Decorators
public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }

    public override double GetCost()
    {
        return base.GetCost() + 20; // Adding the cost of milk
    }

    public override string GetDescription()
    {
        return base.GetDescription() + ", Milk";
    }
}

public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee) { }

    public override double GetCost()
    {
        return base.GetCost() + 10; // Adding the cost of sugar
    }

    public override string GetDescription()
    {
        return base.GetDescription() + ", Sugar";
    }
}

public class ChocolateDecorator : CoffeeDecorator
{
    public ChocolateDecorator(ICoffee coffee) : base(coffee) { }

    public override double GetCost()
    {
        return base.GetCost() + 30; // Adding the cost of chocolate
    }

    public override string GetDescription()
    {
        return base.GetDescription() + ", Chocolate";
    }
}

// Step 5: Client Code
class Program
{
    static void Main(string[] args)
    {
        // Creating a simple coffee
        ICoffee coffee = new SimpleCoffee();
        Console.WriteLine($"{coffee.GetDescription()} -> Cost: {coffee.GetCost()}");

        // Adding Milk
        coffee = new MilkDecorator(coffee);
        Console.WriteLine($"{coffee.GetDescription()} -> Cost: {coffee.GetCost()}");

        // Adding Sugar
        coffee = new SugarDecorator(coffee);
        Console.WriteLine($"{coffee.GetDescription()} -> Cost: {coffee.GetCost()}");

        // Adding Chocolate
        coffee = new ChocolateDecorator(coffee);
        Console.WriteLine($"{coffee.GetDescription()} -> Cost: {coffee.GetCost()}");

        // Final Output:
        // Simple Coffee -> Cost: 50
        // Simple Coffee, Milk -> Cost: 70
        // Simple Coffee, Milk, Sugar -> Cost: 80
        // Simple Coffee, Milk, Sugar, Chocolate -> Cost: 110
    }
}