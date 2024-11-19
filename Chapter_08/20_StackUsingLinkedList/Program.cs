// Program to demonstrate stack using linked list in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Implements a stack (Last-In-First-Out) using a linked list.
    Covers fundamental stack operations like Push, Pop, and Peek.
    Useful for understanding stack-based algorithms and data management.
*/

namespace _20_StackUsingLinkedList
{
    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    public class Stack
    {
        private Node top;

        // Push method to add an element to the stack
        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = top; // New node points to the current top
            top = newNode; // Update top to the new node
        }

        // Pop method to remove the top element from the stack
        public int Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            int data = top.Data;
            top = top.Next; // Update top to the next node
            return data;
        }

        // Peek method to view the top element without removing it
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return top.Data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public void DisplayStack()
        {
            Node current = top;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate stack using linked list in C# with Visual Studio\n");

            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("Stack contents:");
            stack.DisplayStack();

            Console.WriteLine("\nTop element: " + stack.Peek());

            Console.WriteLine("\nPopped element: " + stack.Pop());

            Console.WriteLine("\nStack contents after pop:");
            stack.DisplayStack();
        }
    }
}
