/*
Program to demonstrate Set Union in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: Union combines distinct elements from multiple sets.
Application: Merging datasets without duplication, e.g., combining customer lists.
*/

namespace SetUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Set Union in C# with Visual Studio\n");

            // Definition: The union of two sets combines all unique elements from both sets.
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

            // Performing union
            set1.UnionWith(set2);

            // Displaying the result
            Console.WriteLine("Union of set1 and set2:");
            foreach (var item in set1)
            {
                Console.WriteLine(item);
            }
        }
    }
}