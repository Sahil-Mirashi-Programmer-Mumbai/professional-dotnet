/*
Program to demonstrate Set Intersection in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: Intersection identifies common elements in datasets.
Application: Finding mutual friends in social networks, shared data in systems.
*/

namespace SetIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Set Intersection in C# with Visual Studio\n");

            // Definition: The intersection of two sets contains only the elements present in both sets
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 2, 3, 4 };

            // Performing intersection
            set1.IntersectWith(set2);

            // Displaying the result
            Console.WriteLine("Intersection of set1 and set2:");
            foreach (var item in set1)
            {
                Console.WriteLine(item);
            }
        }
    }
}