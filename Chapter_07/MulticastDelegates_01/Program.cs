// Program to demonstrate multicast delegates in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Multicast Delegates: A single delegate instance can reference multiple methods.
    Combining Methods: Methods are combined using the += operator.
    Usage: Invoking a multicast delegate calls all referenced methods.
*/

namespace MulticastDelegates_01
{
    // Define a delegate that matches the method with no parameters and void return type
    public delegate void Notify();
    internal class Program
    {
        // Two methods matching the delegate signature
        static void NotifyUer()
        {
            Console.WriteLine("User notification sent");
        }

        static void NotifyAdmin()
        {
            Console.WriteLine("Admin notification sent");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate multicast delegates in C# with Visual Studio\n");

            // Creating multicast delegate
            Notify notify = NotifyUer;
            notify += NotifyAdmin; // Adding another method to delegate chain

            notify(); // Output: User notification sent Admin notification sent
        }
    }
}
