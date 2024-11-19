// Program to demonstrate detect and remove loop in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Demonstrates detecting and removing a loop in a linked linkedList using Floyd’s Cycle-Finding Algorithm.
    Critical for data validation and ensuring data structure integrity.
*/

namespace _18_DetectAndRemoveLoop
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

        // Method to create a loop in the linked linkedList for demonstration
        public void CreateLoop()
        {
            if (head == null) return;

            Node last = head;
            Node second = head.Next;

            while (last.Next != null)
            {
                last = last.Next;
            }

            // Creating a loop by pointing the last node to the second node
            last.Next = second;
        }

        // Method to detect and remove a loop in the linked linkedList
        public bool DetectAndRemoveLoop()
        {
            if (head == null) return false;

            Node slow = head;
            Node fast = head;

            // Detecting the loop using Floyd's Cycle-Finding Algorithm
            while (slow != null && fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                // If slow and fast meet, a loop is detected
                if (slow == fast)
                {
                    RemoveLoop(slow);
                    return true;
                }
            }
            return false;
        }

        private void RemoveLoop(Node loopNode)
        {
            Node ptr1 = head;
            Node ptr2 = loopNode;

            // Finding the node where the loop starts
            while (ptr1.Next != ptr2.Next)
            {
                ptr1 = ptr1.Next;
                ptr2 = ptr2.Next;
            }

            // Breaking the loop
            ptr2.Next = null;
        }

        public void DisplayList()
        {
            Node current = head;
            int count = 0; // Safety count to prevent infinite loops
            while (current != null && count < 20)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
                count++;
            }
            Console.WriteLine("null");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate detect and remove loop in C# with Visual Studio\n");

            LinkedList linkedList = new LinkedList();
            linkedList.AddNode(10);
            linkedList.AddNode(20);
            linkedList.AddNode(30);
            linkedList.AddNode(40);

            // Creating a loop for demonstration
            linkedList.CreateLoop();

            // Detecting and removing the loop
            if (linkedList.DetectAndRemoveLoop())
            {
                Console.WriteLine("Loop detected and removed.");
            }
            else
            {
                Console.WriteLine("No loop detected.");
            }

            // Displaying the linkedList after loop removal
            Console.WriteLine("\nLinked linkedList after loop removal:");
            linkedList.DisplayList(); // Should display without loop
        }
    }
}
