// Program to demonstrate Multiple Interface Implementation in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace MultipleInterfaceImplementation_01
{
    // Defining first interface
    interface IPrint
    {
        void Print();
    }

    // Defining second interface
    interface IScan
    {
        void Scan();
    }

    // Implementing both the interfaces in 'MultifunctionPrinter' class
    class MultifunctionPrinter : IPrint, IScan
    {
        public void Print()
        {
            Console.WriteLine("Printing document");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning document");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Multiple Interface Implementation in C# with Visual Studio\n");
            MultifunctionPrinter printer = new MultifunctionPrinter();
            printer.Print(); // Output: Printing document
            printer.Scan(); // Output: Scanning document
        }
    }
}
