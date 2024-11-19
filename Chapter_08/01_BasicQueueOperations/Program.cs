// Program to demonstrate Basic Queue Operations in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Detailed Explanation:
    Queue Definition:
    A queue is a data structure that works based on the FIFO (First-In, First-Out) principle. This means that elements are processed in the order they are added, much like a line at a ticket counter.
    
    Enqueue Operation:
    Adding elements to a queue using the Enqueue method places them at the end of the queue.
    
    Dequeue Operation:
    Removing elements from the front of the queue using the Dequeue method retrieves and removes the first inserted element. If the queue is empty, calling Dequeue throws an exception.
    
    Peek Operation:
    The Peek method retrieves the element at the front of the queue without removing it. This is useful to see the next element to be processed.
   
    Contains Method:
    This method checks if a specific element exists within the queue.

    Clear Method:
    The Clear method removes all elements from the queue, making it empty.
    Queue Applications:

    Queues are used in scenarios where order matters, such as:
    Task scheduling
    Print queues in printers
    Handling requests in web servers
    Message queues for asynchronous processing
*/

namespace _01_BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Basic Queue Operations in C# with Visual Studio\n");

            // Queue definition: A queue is a collection that works on the principle of First-In, First-Out (FIFO).
            // The element that is inserted first is removed first.

            // Creating a queue of integers using the Queue<T> generic class
            Queue<int> numbersQueue = new Queue<int>();

            // Enqueue operation: Adding elements to the end of the queue.
            // This represents inserting elements into the queue.
            numbersQueue.Enqueue(10);
            numbersQueue.Enqueue(20);
            numbersQueue.Enqueue(30);

            // Printing all elements in the queue after enqueue operations.
            Console.WriteLine("Elements in the queue after enqueue operations:");
            foreach (int number in numbersQueue)
            {
                Console.WriteLine(number);
            }

            // Dequeue operation: Removing the element from the front of the queue.
            // The Dequeue method removes and returns the element at the front.
            int dequeuedElement = numbersQueue.Dequeue(); // Removes 10
            Console.WriteLine("\nDequeued Element: " + dequeuedElement);

            // Peek operation: Viewing the element at the front of the queue without removing it.
            // This is useful to check the next element to be dequeued.
            int peekedElement = numbersQueue.Peek(); // Returns 20 but does not remove it
            Console.WriteLine("Element at the front after one dequeue: " + peekedElement);

            // Checking if the queue contains a specific element
            bool containsTwenty = numbersQueue.Contains(20);
            Console.WriteLine("\nDoes the queue contain '20'? " + containsTwenty);

            // Printing the remaining elements in the queue
            Console.WriteLine("\nRemaining elements in the queue:");
            foreach (int number in numbersQueue)
            {
                Console.WriteLine(number);
            }

            // Clear operation: Removing all elements from the queue.
            // The Clear method removes all elements, making the queue empty.
            numbersQueue.Clear();
            Console.WriteLine("\nQueue cleared. Total elements now: " + numbersQueue.Count);
        }
    }
}
