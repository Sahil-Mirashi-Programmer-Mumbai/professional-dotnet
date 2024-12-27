/*
Definition:
The Abstract Factory Pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.

Applications:
When the system needs to be independent of how its objects are created.
When the system should be configured with one of multiple families of products
*/

namespace AbstractFactoryPatternExample
{
    // Abstract Product A
    public interface IChair
    {
        void SitOn();
    }

    // Abstract Product B
    public interface ISofa
    {
        void LayOn();
    }

    // Concrete Product A1
    public class VictorianChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("Sitting on a Victorian Chair.");
        }
    }

    // Concrete Product A2
    public class ModernChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("Sitting on a Modern Chair.");
        }
    }

    // Concrete Product B1
    public class VictorianSofa : ISofa
    {
        public void LayOn()
        {
            Console.WriteLine("Laying on a Victorian Sofa.");
        }
    }

    // Concrete Product B2
    public class ModernSofa : ISofa
    {
        public void LayOn()
        {
            Console.WriteLine("Laying on a Modern Sofa.");
        }
    }

    // Abstract Factory
    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
    }

    // Concrete Factory 1
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        // Functional programming or lambda expression
        public IChair CreateChair() => new VictorianChair();
        public ISofa CreateSofa() => new VictorianSofa();
    }

    // Concrete Factory 2
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        // Functional programming or lambda expression
        public IChair CreateChair() => new ModernChair();
        public ISofa CreateSofa() => new ModernSofa();
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a Victorian Furniture Factory
            IFurnitureFactory victorianFactory = new VictorianFurnitureFactory();
            IChair victorianChair = victorianFactory.CreateChair();
            ISofa victorianSofa = victorianFactory.CreateSofa();
            victorianChair.SitOn();
            victorianSofa.LayOn();

            // Create a Modern Furniture Factory
            IFurnitureFactory modernFactory = new ModernFurnitureFactory();
            IChair modernChair = modernFactory.CreateChair();
            ISofa modernSofa = modernFactory.CreateSofa();
            modernChair.SitOn();
            modernSofa.LayOn();

            Console.ReadLine();
        }
    }
}

/*
Explanation of Code:

Abstract Products (IChair, ISofa):
Define interfaces for various product families.

Concrete Products (VictorianChair, ModernChair, etc.):
Implement the abstract products with specific behaviors.

Abstract Factory (IFurnitureFactory):
Declares methods to create abstract products.

Concrete Factories:
Implement the creation of specific product families.

Main Method:
Demonstrates creating families of products using different factories.
*/