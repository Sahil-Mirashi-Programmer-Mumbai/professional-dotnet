// Program to demonstrate Basic Stack Operations in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    This basic example demonstrates stack operations like Push, Pop, and Peek.
    Stacks are Last-In, First-Out (LIFO) data structures, meaning the last element added is the first to be removed.
    Useful for function call management, reversing data, and more.
*/

namespace _06_BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Basic Stack Operations in C# with Visual Studio\n");

            // Creating a stack of integers
            Stack<int> stack = new Stack<int>();

            // Pushing elements onto the stack (adding elements to the stack)
            stack.Push(10); // The stack now contains: 10 (top)
            stack.Push(20); // The stack now contains: 20 (top), 10
            stack.Push(30); // The stack now contains: 30 (top), 20, 10

            Console.WriteLine("Stack after pushing 10, 20, 30:");
            foreach (int item in stack)
            {
                Console.WriteLine(item); // Displaying elements (Last In, First Out order)
            }

            // Peeking at the top element (without removing it)
            int topElement = stack.Peek();
            Console.WriteLine($"\nTop element (peek): {topElement}");

            // Popping elements from the stack (removing elements)
            int removedElement = stack.Pop(); // Removes 30 (top)
            Console.WriteLine($"\nPopped element: {removedElement}");

            Console.WriteLine("\nStack after popping an element:");
            foreach (int item in stack)
            {
                Console.WriteLine(item); // Remaining elements: 20, 10
            }

            // Checking if the stack contains a specific element
            bool containsTen = stack.Contains(10);
            Console.WriteLine($"\nStack contains 10: {containsTen}");
        }
    }
}