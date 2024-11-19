// Program to demonstrate Doubly Linked List example in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Introduces the concept of doubly linked lists, where each node points to both the next and previous nodes.
    Useful in scenarios requiring bi-directional traversal, like navigation history.
*/

namespace _14_DoublyLinkedListExample
{
    public class Node
    {
        public int Data;
        public Node Next;
        public Node Previous; // Points to the previous node

        public Node(int data)
        {
            Data = data;
            Next = null;
            Previous = null;
        }
    }

    public class DoublyLinkedList
    {
        private Node head;

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
            newNode.Previous = current; // Establish backward link
        }

        public void DisplayForward()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }

        public void DisplayBackward()
        {
            if (head == null) return;

            // Move to the last node
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            // Traverse backward using the Previous pointer
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Previous;
            }
            Console.WriteLine("null");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Doubly Linked List xxample in C# with Visual Studio\n");

            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
            doublyLinkedList.AddNode(10);
            doublyLinkedList.AddNode(20);
            doublyLinkedList.AddNode(30);

            Console.WriteLine("Doubly linked doublyLinkedList (forward traversal):");
            doublyLinkedList.DisplayForward(); // Output: 10 -> 20 -> 30 -> null

            Console.WriteLine("\nDoubly linked doublyLinkedList (backward traversal):");
            doublyLinkedList.DisplayBackward(); // Output: 30 -> 20 -> 10 -> null
        }
    }
}