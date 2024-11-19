// Program to demonstrate doubly finding length linked linkedList in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Demonstrates finding the length of a linked linkedList.
    Useful for understanding traversal and linkedList size management.
*/

namespace _15_FindingLengthLinkedList
{
    class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    class LinkedList
    {
        Node head;
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

        public int GetLength()
        {
            int length = 0;
            Node current = head;
            while (current != null)
            {
                length++;
                current = current.Next;
            }
            return length;
        }

        public void DisplayNode()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write($"{current.Data} -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate doubly finding length linked linkedList in C# with Visual Studio\n");

            LinkedList linkedList = new LinkedList();
            linkedList.AddNode(20);
            linkedList.AddNode(70);
            linkedList.AddNode(40);
            linkedList.AddNode(50);

            linkedList.DisplayNode();

            Console.WriteLine($"Length: {linkedList.GetLength()}");
        }
    }

}