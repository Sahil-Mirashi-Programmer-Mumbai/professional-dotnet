/*
Definition:
The Singleton Pattern ensures that a class has only one instance and provides a global point of access to that instance/object.

Why it is used:
To restrict the instantiation of a class to a single object, often used for things like configuration settings, logging, and database connections.
*/

namespace SingletonPattern
{
    public class Singleton
    {
        // Create private static variable that holds the single instance/object
        private static Singleton _instance;

        // Make constructor private to prevent direct instantiation/creation
        private Singleton()
        {
            Console.WriteLine("Singleton Instance Created");
        }

        // Expose public static method to access the single instance/object
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Accessing the Singleton instance
            Singleton instance1 = Singleton.GetInstance();
            Singleton instance2 = Singleton.GetInstance();

            // Checking if both instances are the same
            Console.WriteLine(instance1 == instance2);  // Output: True
        }
    }
}