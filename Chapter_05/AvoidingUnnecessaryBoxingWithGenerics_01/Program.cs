// Program to demonstrate Avoiding Unnecessary Boxing with Generics in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Using generic collections like List<T> prevents boxing/unboxing overhead.
    This example contrasts with the previous one, demonstrating why generics are preferred for value type storage.
*/

namespace AvoidingUnnecessaryBoxingWithGenerics_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Avoiding Unnecessary Boxing with Generics in C# with Visual Studio\n");

            // Using List<int> which is a generic collection (avoids boxing/unboxing)
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // No boxing/unboxing required to store or retrieve elements
            foreach (int number in numbers)
            {
                Console.WriteLine($"Number: {number}");
            }
        }
    }
}
