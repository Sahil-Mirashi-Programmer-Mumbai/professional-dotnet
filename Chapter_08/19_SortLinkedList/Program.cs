// Program to demonstrate sort linked list in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Demonstrates sorting a linked list using the Bubble Sort algorithm.
    Useful for data organization and order management.
*/

namespace _19_SortLinkedList
{
    // Supporting Node class to represent an element in the linked list.
    public class Node
    {
        public int Data { get; set; } // Property to store the data of the node.
        public Node Next { get; set; } // Property to store the reference to the next node.

        public Node(int data) // Constructor to initialize the node with data.
        {
            Data = data; // Set the data.
            Next = null; // Initialize the next reference as null.
        }
    }

    public class LinkedList
    {
        private Node head; // Head node of the linked list.

        // Method to add a new node at the end of the linked list.
        public void AddNode(int data)
        {
            Node newNode = new Node(data); // Create a new node with the given data.
            if (head == null) // If the list is empty, make the new node the head.
            {
                head = newNode;
                return;
            }

            Node current = head; // Start traversing from the head.
            while (current.Next != null) // Traverse to the last node.
            {
                current = current.Next;
            }
            current.Next = newNode; // Add the new node at the end.
        }

        // Method to sort the linked list using Bubble Sort.
        public void Sort()
        {
            if (head == null || head.Next == null) // If the list is empty or has only one node, it's already sorted.
            {
                return;
            }

            bool swapped; // Flag to track if any swaps are made.
            do
            {
                Node current = head; // Start from the head node.
                Node next = head.Next; // Pointer to the next node.
                Node previous = null; // Pointer to the previous node for swapping adjustments.
                swapped = false; // Reset the swapped flag.

                while (next != null) // Loop until the end of the list.
                {
                    if (current.Data > next.Data) // If the current node's data is greater than the next node's data, swap.
                    {
                        // Perform swapping by adjusting the `Next` pointers.
                        if (previous == null) // If swapping involves the head node.
                        {
                            head = next;
                        }
                        else
                        {
                            previous.Next = next;
                        }

                        current.Next = next.Next;
                        next.Next = current;

                        // Update the `previous` pointer to the swapped node.
                        swapped = true;
                        previous = next;
                    }
                    else
                    {
                        // If no swap is needed, just move the pointers forward.
                        previous = current;
                        current = next;
                    }
                    next = current.Next; // Update the `next` pointer.
                }
            } while (swapped); // Repeat until no swaps are needed.
        }

        // Method to display the elements of the linked list.
        public void DisplayList()
        {
            Node current = head; // Start from the head.
            while (current != null) // Traverse until the end of the list.
            {
                Console.Write(current.Data + " -> "); // Print the data in the current node.
                current = current.Next; // Move to the next node.
            }
            Console.WriteLine("null"); // Indicate the end of the list.
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate sort linkedList in C# with Visual Studio\n");

            LinkedList linkedList = new LinkedList();
            linkedList.AddNode(40);
            linkedList.AddNode(10);
            linkedList.AddNode(30);
            linkedList.AddNode(20);

            Console.WriteLine("Original linkedList:");
            linkedList.DisplayList();

            // Sorting the linked linkedList
            linkedList.Sort();

            Console.WriteLine("\nSorted linkedList:");
            linkedList.DisplayList();
        }
    }
}
