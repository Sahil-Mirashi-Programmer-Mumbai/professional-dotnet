/*
Program to demonstrate Detect Duplicates in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: HashSet ensures unique additions, making it ideal for duplicate detection.
Application: Data cleansing, removing duplicates in user input or files.
*/

namespace DetectDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Detect Duplicates in C# with Visual Studio\n");

            List<int> numbers = new List<int> { 1, 2, 3, 4, 2, 3, 5 };
            HashSet<int> uniqueNumbers = new HashSet<int>();

            foreach (var num in numbers)
            {
                if (!uniqueNumbers.Add(num))
                {
                    Console.WriteLine($"Duplicate detected: {num}");
                }
            }
        }
    }
}