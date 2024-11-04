// Program to demonstrate Explicit Interface Implementation in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace ExplicitInterfaceImplementation_01
{
    interface IReadable
    {
        void Read();
    }

    interface IWritable
    {
        void Write();
    }

    class Document : IReadable, IWritable
    {
        // Explicity implementing interface
        public void Read()
        {
            Console.WriteLine("Reading document");
        }

        public void Write()
        {
            Console.WriteLine("Writing to document");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Explicit Interface Implementation in C# with Visual Studio\n");

            Document document = new Document();

            // Explicitly casting to 'IReadable' and 'IWriteable' interface
            ((IReadable)document).Read(); // Output: Reading document
            ((IWritable)document).Write(); // Output: Writing to document
        }
    }
}
