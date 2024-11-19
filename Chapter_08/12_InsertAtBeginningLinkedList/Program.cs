// Program to demonstrate insert at beginning Linked List in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Shows how to insert a new node at the beginning of a linked list.
    Useful in cases where insertions at the start of the list need to be optimized.
    Helps students understand pointer manipulation.
*/

namespace _12_InsertAtBeginningLinkedList
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

        // Method to insert a node at the beginning of the list
        public void InsertAtBeginning(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = head; // Point the new node's next to the current head
            head = newNode; // Update head to point to the new node
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

            list.InsertAtBeginning(30);
            list.InsertAtBeginning(20);
            list.InsertAtBeginning(10);

            Console.WriteLine("Linked list after inserting elements at the beginning:");
            list.DisplayList(); // Output: 10 -> 20 -> 30 -> null
        }
    }
}
