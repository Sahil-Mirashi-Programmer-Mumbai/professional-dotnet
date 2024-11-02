// Program to demonstrate passing reference types with ref in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace PassingReferenceTypesWithRef_01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate passing reference types with ref in C# with Visual Studio\n");
            string text = "Hello";
            Console.WriteLine($"Before method call: {text}"); // Output: Hello

            // Pass a reference type using 'ref'
            AppendText(ref text);
            Console.WriteLine($"After method call: {text}"); // Output: Hello World!
        }

        static void AppendText(ref string text)
        {
            // Modify original string by appending text
            text += " World!";
        }
    }
}
