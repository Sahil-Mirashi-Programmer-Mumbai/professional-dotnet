/*
    Program to demonstrate converting span to substring in strings in C# with Visual Studio
    Programmer: Sahil Mirashi

    ReadOnlySpan<T> is a readonly version of Span<T>, preventing modifications.
    Useful for memory-efficient substring extraction and manipulation.
    Span<T> and ReadOnlySpan<T> provide performance benefits by avoiding string allocations.
*/

namespace ConvertingSpanToSubstringInStrings_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate converting span to substring in strings in C# with Visual Studio\n");

            // Declaring and initializing a string
            string text = "Hello, World!";

            // Creating a ReadOnlySpan<char> from the string
            // ReadOnlySpan<T> is a readonly view of the original data
            ReadOnlySpan<char> readOnlySpan = text.AsSpan();

            // Extracting a substring using Span
            ReadOnlySpan<char> helloSpan = readOnlySpan.Slice(0, 5);

            // Converting Span<char> to string for display
            string extractedText = helloSpan.ToString();
            Console.WriteLine(extractedText); // Output: Hello
        }
    }
}
