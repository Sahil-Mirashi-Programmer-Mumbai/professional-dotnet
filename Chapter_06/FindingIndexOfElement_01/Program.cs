// Program to demonstrate finding index of element in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace FindingIndexOfElement_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate finding index of element in C# with Visual Studio\n");

            // Creating an array of strings
            string[] fruits = { "Mango", "Orange", "Apple", "Cherry", "Pineapple"};

            // Finding the index of an element using Array.IndexOf
            // Array.IndexOf returns the index of the first occurrence of the specified element
            int index = Array.IndexOf(fruits, "Apple");

            // Checking if the element was found
            if(index >= 0 )
            {
                Console.WriteLine($"The element 'Apple' is at index {index}");
            }
            else
            {
                Console.WriteLine("The element 'Apple' was not found");
            }
        }
    }
}
