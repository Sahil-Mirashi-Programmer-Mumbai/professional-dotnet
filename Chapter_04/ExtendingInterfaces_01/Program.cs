// Program to demonstrate Extending Interfaces in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace ExtendingInterfaces_01
{
    // Base interface
    interface IWork
    {
        void Start();
    }

    // Derived interface
    interface IAdvancedWork : IWork
    {
        void Stop();
    }

    // Implementing the 'IWork' and 'IAdvancedWork' interface
    class Machine : IAdvancedWork
    {
        public void Start()
        {
            Console.WriteLine("Machine started");
        }

        public void Stop()
        {
            Console.WriteLine("Machine stopped");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Extending Interfaces in C# with Visual Studio\n");

            Machine machine = new Machine();
            machine.Start();
            machine.Stop();
        }
    }
}
