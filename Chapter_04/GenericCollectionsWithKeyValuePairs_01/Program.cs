// Program to demonstrate Generic Collections With Key Value Pairs in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    This example demonstrates a Dictionary<TKey, TValue>, a generic collection that stores key-value pairs.
    Dictionary<TKey, TValue> is a generic collection for key-value pairs, where TKey is the type for keys, and TValue is the type for values.
    This example uses an int as TKey and string as TValue.
    Application: Dictionaries are ideal for scenarios where data needs to be stored and accessed by unique identifiers, like IDs in databases.
*/

namespace GenericCollectionsWithKeyValuePairs_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Generic Collections With Key Value Pairs in C# with Visual Studio\n");

            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(1, "Tom");
            students.Add(2, "Sam");
            students.Add(3, "Max");

            foreach(KeyValuePair<int, string> student in students)
            {
                Console.WriteLine($"ID: {student.Key} Name: {student.Value}");
            }
        }
    }
}
