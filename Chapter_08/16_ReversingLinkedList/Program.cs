// Program to demonstrate reversing linked list in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Demonstrates reversing a linked list by adjusting node pointers.
    Important for understanding pointer manipulation and use cases such as reversing orders in data processing.
*/

namespace _16_ReversingLinkedList
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

    public class LinkedList
    {
        private Node head;

        // Method to add a new node to the end of the list
        public void AddNode(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        // Method to reverse the linked list
        public void ReverseList()
        {
            Node previous = null;
            Node current = head;
            Node next = null;

            while (current != null)
            {
                next = current.Next; // Store next node
                current.Next = previous; // Reverse current node's pointer
                previous = current; // Move pointers one step forward
                current = next;
            }
            head = previous; // Update head to new front node
        }

        public void DisplayList()
        {
            Node current = head;
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
            LinkedList list = new LinkedList();
            list.AddNode(10);
            list.AddNode(20);
            list.AddNode(30);

            Console.WriteLine("Original linked list:");
            list.DisplayList(); // Output: 10 -> 20 -> 30 -> null

            list.ReverseList();

            Console.WriteLine("\nReversed linked list:");
            list.DisplayList(); // Output: 30 -> 20 -> 10 -> null
        }
    }
}