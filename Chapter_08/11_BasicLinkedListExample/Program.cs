// Program to demonstrate Basic Linked List Example in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    A simple linked linkedList where nodes are connected sequentially.
    Demonstrates node creation, adding elements, and traversal.
    Applications include dynamic memory allocation and creating custom data structures like stacks and queues.
*/

namespace _11_BasicLinkedListExample
{
    // Class representing a node in the linked linkedList
    public class Node
    {
        public int Data; // Holds the value of the node
        public Node Next; // Points to the address of the next node in the linkedList

        public Node(int data)
        {
            Data = data;
            Next = null; // Initialize as null since this is a single node for now
        }
    }

    // Class representing the linked linkedList
    public class LinkedList
    {
        private Node head; // Points to the first node (head) of the linkedList

        // Method to add a new node to the end of the linkedList
        public void AddNode(int data)
        {
            Node newNode = new Node(data); // Create a new node
            
            // If the linkedList is empty, set the new node as the head
            if (head == null)
            {
                head = newNode;
                return;
            }

            // Traverse to the end of the linkedList and add the new node
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next; // Move to the next node
            }
            current.Next = newNode; // Point the last node to the new node
        }

        // Method to display the contents of the linkedList
        public void DisplayList()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null"); // Indicates the end of the linkedList
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Basic Linked List Example in C# with Visual Studio\n");

            LinkedList linkedList = new LinkedList();

            // Adding elements to the linked linkedList
            linkedList.AddNode(10);
            linkedList.AddNode(20);
            linkedList.AddNode(30);

            // Display the linked linkedList
            Console.WriteLine("Linked linkedList contents:");
            linkedList.DisplayList(); // Output: 10 -> 20 -> 30 -> null
        }
    }
}