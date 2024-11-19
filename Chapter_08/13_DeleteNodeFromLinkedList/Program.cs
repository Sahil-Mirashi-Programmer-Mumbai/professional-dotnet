// Program to demonstrate Delete Node from Linked List in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Demonstrates how to delete a node by value from the linkedList.
    Shows traversal and node reference management for deletion.
    Useful in linkedList management applications such as maintaining active sessions.
*/

namespace _13_DeleteNodeFromLinkedList
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
        private Node head;

        public void AddNode(int data)
        {
            Node newNode = new Node(data);

            if(head == null)
            {
                head = newNode;
                return;
            }

            Node current = head;
            while(current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public void RemoveNode(int data)
        {
            if(head == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }

            if(head.Data == data)
            {
                head = head.Next;
                return;
            }

            Node current = head;
            Node previous = null;

            while(current != null && current.Data != data)
            {
                previous = current;
                current = current.Next;
            }

            if(current == null)
            {
                Console.WriteLine($"{data} does not exist in linked list");
                return;
            }

            previous.Next = current.Next;
        }

        public void DisplayLinkedList()
        {
            Node current = head;
            while(current != null)
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
            Console.WriteLine("Program to demonstrate Delete Node from Linked List in C# with Visual Studio\n");

            LinkedList linkedList = new LinkedList();
            linkedList.AddNode(90);
            linkedList.AddNode(10);
            linkedList.AddNode(40);
            linkedList.AddNode(20);

            linkedList.DisplayLinkedList();

            linkedList.RemoveNode(22);

            linkedList.DisplayLinkedList();
        }
    }
}