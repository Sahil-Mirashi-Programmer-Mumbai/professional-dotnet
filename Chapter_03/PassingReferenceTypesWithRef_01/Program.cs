// Program to demonstrate passing reference types with ref in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Pass by reference
    When you pass a variable to a method, you are passing a reference to the original variable, not a copy.
    This means that any changes made to the parameter inside the method will affect the original variable outside the method.
*/

namespace PassingReferenceTypesWithRef_01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate passing reference types with ref in C# with Visual Studio\n");
            string text = "Hello";

            Console.WriteLine($"Text before method call: {text}"); // Output: Text before method call: Hello

            // Pass a reference type using 'ref'
            AppendText(ref text);

            Console.WriteLine($"Text after method call: {text}"); // Output: Text after method call: Hello World
        }

        static void AppendText(ref string text)
        {
            text += " World";
        }
    }
}
