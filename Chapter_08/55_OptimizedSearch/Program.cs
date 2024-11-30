/*
Program to demonstrate Optimized Search in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: HashSet allows O(1) average lookup time for search operations.
Application: Improving performance in search-heavy applications.
*/

namespace OptimizedSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Optimized Search in C# with Visual Studio\n");

            HashSet<int> dataSet = new HashSet<int> { 100, 200, 300, 400 };

            int searchValue = 300;
            if (dataSet.Contains(searchValue))
            {
                Console.WriteLine($"Value {searchValue} found.");
            }
            else
            {
                Console.WriteLine($"Value {searchValue} not found.");
            }
        }
    }
}