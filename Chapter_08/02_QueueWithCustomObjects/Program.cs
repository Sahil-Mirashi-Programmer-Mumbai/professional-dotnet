// Program to demonstrate Queue with Custom Objects in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    This example demonstrates how queues can hold objects of a custom class, not just primitive types.
    It illustrates common queue operations (Enqueue, Dequeue, Peek) with a custom object type.
    Useful for task queues, customer service lines, etc., where objects have more complex data.
*/

namespace _02_QueueWithCustomObjects
{
    // Define a custom class representing a person
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Queue with Custom Objects in C# with Visual Studio\n");

            // Creating a queue that holds Person objects
            Queue<Person> personQueue = new Queue<Person>();

            // Adding (enqueueing) custom objects to the queue
            personQueue.Enqueue(new Person("Alice", 25));
            personQueue.Enqueue(new Person("Bob", 30));
            personQueue.Enqueue(new Person("Charlie", 22));

            // Displaying all elements in the queue
            Console.WriteLine("People in the queue:");
            foreach (var person in personQueue)
            {
                Console.WriteLine($"{person.Name}, {person.Age} years old");
            }

            // Removing the first person (FIFO) from the queue
            var removedPerson = personQueue.Dequeue();
            Console.WriteLine($"\nDequeued Person: {removedPerson.Name}, {removedPerson.Age} years old");

            // Peeking at the next person in line without removing them
            var nextPerson = personQueue.Peek();
            Console.WriteLine($"Next Person in Queue: {nextPerson.Name}, {nextPerson.Age} years old");

            // Clearing the queue
            personQueue.Clear();
            Console.WriteLine("\nQueue cleared. Total people now: " + personQueue.Count);
        }
    }
}
