// Program to demonstrate Interface With Default Implementation in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace InterfaceWithDefaultImplementation_01
{
    interface ILogger
    {
        // Default implementation provided for the log method
        void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }

    class ConsoleLogger: ILogger 
    {
        // No need to implement Log method as it's already defined in the interface
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Interface With Default Implementation in C# with Visual Studio\n");

            ILogger logger = new ConsoleLogger();
            logger.Log("System initialized"); // Output: Log: System initialized
        }
    }
}
