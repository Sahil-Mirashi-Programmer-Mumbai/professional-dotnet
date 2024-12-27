/*
Definition:
The Adapter Pattern allows incompatible interfaces to work together by acting as a bridge between them. 
It translates the interface of a class into another interface that a client expects.

Real life analogy: Phone charger, laptop charger

Applications:
When integrating a new class into an existing codebase with an incompatible interface.
When using third-party libraries or legacy code that doesn't match your current system.
*/

namespace AdapterPatternExample
{
    // Existing class (Adaptee)
    public class LegacyPrinter
    {
        public void PrintOldFormat(string text)
        {
            Console.WriteLine($"Legacy Printer: {text}");
        }
    }

    // Target interface
    public interface IPrinter
    {
        void Print(string text);
    }

    // Adapter class
    public class PrinterAdapter : IPrinter
    {
        private LegacyPrinter _legacyPrinter;

        public PrinterAdapter(LegacyPrinter legacyPrinter)
        {
            _legacyPrinter = legacyPrinter;
        }

        public void Print(string text)
        {
            // Adapting the interface
            _legacyPrinter.PrintOldFormat(text);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Existing legacy printer
            LegacyPrinter legacyPrinter = new LegacyPrinter();

            // Adapter to make it compatible
            IPrinter printerAdapter = new PrinterAdapter(legacyPrinter);

            // Using the adapter
            printerAdapter.Print("Hello, Adapter Pattern!");

            Console.ReadLine();
        }
    }
}

/*
Explanation of Code:
Adaptee (LegacyPrinter):
The class with an incompatible interface.

Target Interface (IPrinter):
Defines the expected interface for the client.

Adapter (PrinterAdapter):
Bridges the gap by internally using the LegacyPrinter while implementing IPrinter.

Client (Main Method):
Works seamlessly with the adapter, unaware of the underlying legacy implementation.
*/