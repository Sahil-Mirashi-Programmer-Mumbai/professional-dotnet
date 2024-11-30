/*
Program to demonstrate Set Difference in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: Difference helps to find unique data in one collection compared to another.
Application: Finding users in a list who haven’t logged in recently.
*/

namespace SetDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Set Difference in C# with Visual Studio\n");

            // Definition: The difference of two sets contains elements present in the first set but not in the second.
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

            // Performing difference
            set1.ExceptWith(set2);

            // Displaying the result
            Console.WriteLine("Difference of set1 and set2:");
            foreach (var item in set1)
            {
                Console.WriteLine(item);
            }
        }
    }
}