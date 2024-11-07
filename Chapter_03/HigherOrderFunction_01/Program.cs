// Program to demonstrate Higher Order Function in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace HigherOrderFunction_01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Higher Order Function in C# with Visual Studio\n");

            // Passing a function as an argument
            ExecuteFunction(SayHello);
        }

        static void SayHello()
        {
            Console.WriteLine("Hello from SayHello function");
        }

        static void ExecuteFunction(Action action)
        {
            action();
        }
    }
}
