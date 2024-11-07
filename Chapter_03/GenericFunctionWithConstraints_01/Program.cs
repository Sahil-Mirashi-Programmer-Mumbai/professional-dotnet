// Program to demonstrate Generic Function with Constraints in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace GenericFunctionWithConstraints_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Generic Function with Constraints in C# with Visual Studio\n");

            // DisplayArray<int>(new int[] { 1, 2, 3 }); // Compile time error since int is a value type
            DisplayArray<string>(new string[] { "Tom", "Mike", "Harry"});
        }
        static void DisplayArray<T>(T[] array) where T : class
        {
            foreach(T item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
