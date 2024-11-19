// Program to demonstrate Reversing String using Stack in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    This example shows how a stack can be used to reverse a string.
    Demonstrates LIFO behavior: the last character pushed is the first one to be popped.
    Useful in text processing, parsing, and data transformation scenarios.
*/

namespace _07_ReversingStringUsingStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Reversing String using Stack in C# with Visual Studio\n");

            string input = "Hello, World!";
            Stack<char> charStack = new Stack<char>();

            // Pushing each character of the string onto the stack
            foreach (char c in input)
            {
                charStack.Push(c);
            }

            // Building the reversed string
            string reversed = string.Empty;
            while (charStack.Count > 0)
            {
                reversed += charStack.Pop(); // Pop characters to form the reversed string
            }

            Console.WriteLine($"Original string: {input}");
            Console.WriteLine($"Reversed string: {reversed}");
        }
    }
}