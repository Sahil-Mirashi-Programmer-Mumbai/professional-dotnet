// Program to demonstrate Generic Delegate in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Delegates are references to functions. A generic delegate allows for function references with varying parameter types, enhancing flexibility.
    ProcessDelegate<T> is a generic delegate where T represents the parameter type.
    Execute<T> method accepts an item of type T and a delegate function that processes T.
    Application: Generic delegates simplify callbacks or event handling in cases where parameter types vary.
*/

namespace GenericDelegate_01
{
    delegate void GenericDelegate<T>(T item);

    class Processor
    {
        public void Execute<T>(T item, GenericDelegate<T> process)
        {
            process(item);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Generic Delegate in C# with Visual Studio\n");

            Processor processor = new Processor();

            processor.Execute(20, item => Console.WriteLine($"Processing {item}"));
            processor.Execute("Hello", item => Console.WriteLine($"Processing {item}"));

        }
    }
}