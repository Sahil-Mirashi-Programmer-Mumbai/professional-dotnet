/*
Program to demonstrate Set Subset Superset in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: Subsets and supersets help in hierarchical data relationships.
Application: Role - based access control, validating permissions in a system.
*/

namespace SetSubsetSuperset
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Set Subset Superset in C# with Visual Studio\n");

            // Creating two sets
            HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4 };
            HashSet<int> setB = new HashSet<int> { 2, 3 };

            // Checking if setB is a subset of setA
            bool isSubset = setB.IsSubsetOf(setA);
            Console.WriteLine($"Is setB a subset of setA? {isSubset}");

            // Checking if setA is a superset of setB
            bool isSuperset = setA.IsSupersetOf(setB);
            Console.WriteLine($"Is setA a superset of setB? {isSuperset}");
        }
    }
}