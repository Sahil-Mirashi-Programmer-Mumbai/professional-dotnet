// Program to demonstrate circular linked list example in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Demonstrates how to create a circular linked list where the last node points back to the head.
    Useful for modeling cyclic processes, such as round-robin scheduling.
*/

namespace _17_CircularLinkedListExample
{

    class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }

    class CircularLinkedList
    {
        Node head;

        public void AddNode(int  data)
        {
            Node newNode = new Node(data);

            if(head == null)
            {
                head = newNode;
                newNode.next = head;
                return;
            }

            Node current = head;
            while(current.next != head)
            {
                current = current.next;
            }
            newNode.next = current.next;
            current.next = newNode;
        }

        public void DisplayCircularLinkedList()
        {
            Node current = head;
            do
            {
                Console.Write($"{current.data} -> ");
                current = current.next;
            }
            while (current != head);

            Console.WriteLine("Head reached");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate circular linked list example in C# with Visual Studio\n");
            
            CircularLinkedList circularLinkedList = new CircularLinkedList();
            circularLinkedList.AddNode(70);
            circularLinkedList.AddNode(20);
            circularLinkedList.AddNode(40);
            circularLinkedList.AddNode(90);
            circularLinkedList.AddNode(10);

            circularLinkedList.DisplayCircularLinkedList();
        }
    }
}