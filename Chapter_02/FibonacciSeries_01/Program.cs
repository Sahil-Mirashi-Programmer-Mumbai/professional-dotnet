// Program to demonstrate Fibonacci Series in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace FibonacciSeries_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Fibonacci Series in C# with Visual Studio\n");

            Console.Write("Enter number of terms: ");

            int terms = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < terms; i++)
            {
                Console.WriteLine($"{Fibonacci(i)}");
            }
        }

        static int Fibonacci(int terms)
        {
            if (terms <= 1) // Base condition
                return terms;
            else
                return Fibonacci(terms - 1) + Fibonacci(terms - 2); // Incremental or decremental recursive calling
        }

    }
}
