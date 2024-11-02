namespace CreatingBasicTuple_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a Tuple to hold two values, both an integer and a string.
            Tuple<int, string> person = new Tuple<int, string>(1, "Alice");

            // Accessing Tuple elements by Item1 and Item2 properties.
            Console.WriteLine("ID: " + person.Item1);       // Output: ID: 1
            Console.WriteLine("Name: " + person.Item2);     // Output: Name: Alice
        }
    }
}
