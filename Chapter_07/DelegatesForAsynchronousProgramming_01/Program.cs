// Program to demonstrate Delegates for Asynchronous Programming in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Asynchronous Invocation: BeginInvoke and EndInvoke enable async delegate execution.
    Non-Blocking Operations: Main thread continues while the task runs asynchronously.
*/

namespace DelegatesForAsynchronousProgramming_01
{
    // Delegate with no parameters and void return type
    public delegate void LongRunningTask();

    class Program
    {
        // Simulates a long-running task
        public static void TaskMethod()
        {
            Console.WriteLine("Task Started");
            Task.Delay(1000);
            Console.WriteLine("Task Completed");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Delegates for Asynchronous Programming in C# with Visual Studio\n");


            // Initiating the task asynchronously
            LongRunningTask longRunningTask = new LongRunningTask(TaskMethod);
            IAsyncResult result = longRunningTask.BeginInvoke(null, null);

            Console.WriteLine("Main Thread is Free to Continue");

            // Waiting for the task to complete
            longRunningTask.EndInvoke(result);
        }
    }
}
