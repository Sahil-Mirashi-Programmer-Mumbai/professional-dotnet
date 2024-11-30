/*
Program to demonstrate Hash Set Basics in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: The HashSet ensures uniqueness of elements.
Application: Avoiding duplicate entries, e.g., tracking unique user IDs.
*/

namespace HashSetBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Hash Set Basics in C# with Visual Studio\n");

            // Definition: A HashSet is a collection of unique elements. 
            // It does not allow duplicate values and provides fast lookup.

            // Creating a HashSet of integers
            HashSet<int> numbers = new HashSet<int> { 1, 2, 3, 4 };

            // Adding an element to the HashSet
            numbers.Add(5); // Adds successfully
            numbers.Add(3); // Will not add as 3 already exists

            // Removing an element
            numbers.Remove(2);

            // Displaying all elements in the HashSet
            Console.WriteLine("HashSet elements:");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}