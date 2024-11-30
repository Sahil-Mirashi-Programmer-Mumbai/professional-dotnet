/*
Program to demonstrate Compare Sets in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: Comparing sets ensures data consistency.
Application: Validating configuration files or database integrity.
*/

namespace CompareSets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Compare Sets in C# with Visual Studio\n");

            HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4 };
            HashSet<int> setB = new HashSet<int> { 1, 2, 3, 4 };

            // Checking if sets are equal
            bool areEqual = setA.SetEquals(setB);
            Console.WriteLine($"Are setA and setB equal? {areEqual}");
        }
    }
}