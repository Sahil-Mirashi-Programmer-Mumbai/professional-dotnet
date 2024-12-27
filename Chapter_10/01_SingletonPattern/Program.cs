/*
Definition:
The Singleton Pattern ensures that a class has only one instance and provides a global point of access to it. 
This is useful when exactly one object is needed to coordinate actions across the system.

Applications:
Managing shared resources such as a database connection pool or a configuration manager.
Logging mechanisms where a single logger instance is required.
Accessing thread pools.
*/

namespace SingletonPatternExample
{
    // Singleton class
    public sealed class Singleton
    {
        // Static instance to hold the single object
        private static Singleton _instance = null;

        // Lock object to handle thread safety
        private static readonly object _lock = new object();

        // Private constructor prevents instantiation from other classes
        private Singleton()
        {
            Console.WriteLine("Singleton Instance Created.");
        }

        // Public method to provide access to the Singleton instance
        public static Singleton Instance
        {
            get
            {
                // Double-checked locking for thread safety
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;
            }
        }

        // Example method within the Singleton
        public void ShowMessage()
        {
            Console.WriteLine("Singleton Pattern: Only one instance exists!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Access Singleton instance
            Singleton singleton1 = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;

            // Call method on the Singleton
            singleton1.ShowMessage();

            // Confirming both references point to the same instance
            Console.WriteLine($"singleton1 and singleton2 are the same instance: {object.ReferenceEquals(singleton1, singleton2)}");

            Console.ReadLine();
        }
    }
}

/*
Explanation of Code:
sealed class Singleton :
Ensures the class cannot be inherited, preventing additional instances from being created.

private static Singleton _instance:
Holds the single instance of the class, initially set to null.

private static readonly object _lock:
Used to synchronize access across multiple threads to ensure only one instance is created.

private Singleton():
The constructor is private, restricting object creation from outside the class.

Double - checked locking in the Instance property:
First checks if _instance is null. If true, it locks the block of code and checks again before instantiating, ensuring thread safety.

ShowMessage method:
Demonstrates that the Singleton object can perform actions.

Main method:
Accesses the Singleton instance and demonstrates that multiple calls refer to the same instance.
*/