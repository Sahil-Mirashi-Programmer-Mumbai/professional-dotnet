// Program to demonstrate using Queue for Task Scheduling in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    This example simulates a basic task scheduler where tasks are processed in order.
    Real-world applications include scheduling jobs in web servers, cron jobs, etc.
    Demonstrates how queues are useful for managing a list of tasks to be executed.
*/

namespace _03_UsingQueueForTaskScheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate using Queue for Task Scheduling in C# with Visual Studio\n");

            // Simulating a task scheduler using a queue of strings (task descriptions)
            Queue<string> taskQueue = new Queue<string>();

            // Adding tasks to the queue
            taskQueue.Enqueue("Task 1: Backup files");
            taskQueue.Enqueue("Task 2: Send email notifications");
            taskQueue.Enqueue("Task 3: Update database records");

            // Processing tasks one by one
            Console.WriteLine("Processing tasks...");
            while (taskQueue.Count > 0)
            {
                // Removing and displaying the next task to be processed
                string currentTask = taskQueue.Dequeue();
                Console.WriteLine("Processing: " + currentTask);
            }

            Console.WriteLine("\nAll tasks completed.");
        }
    }
}
