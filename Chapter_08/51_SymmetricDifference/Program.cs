/*
Program to demonstrate Symmetric Difference in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: Symmetric difference is useful for identifying mismatches in datasets.
Application: Comparing two lists of orders to find unmatched entries.
*/

namespace SymmetricDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Symmetric Difference in C# with Visual Studio\n");

            // Definition: Symmetric difference contains elements in either of the sets but not in both.
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

            // Performing symmetric difference
            set1.SymmetricExceptWith(set2);

            // Displaying the result
            Console.WriteLine("Symmetric difference of set1 and set2:");
            foreach (var item in set1)
            {
                Console.WriteLine(item);
            }
        }
    }
}