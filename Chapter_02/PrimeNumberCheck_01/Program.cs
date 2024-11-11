// Program to demonstrate Prime Number Check in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace PrimeNumberCheck_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Prime Number Check in C# with Visual Studio\n");

            Console.Write("Enter a number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            if(IsPrime(number))
            {
                Console.WriteLine($"{number} is a prime number");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number");
            }
        }

        static bool IsPrime(int number)
        {
            if(number <= 1)
                return false;
            else
            {
                for(int loopCounter = 2; loopCounter * loopCounter < number; loopCounter++)
                {
                    if(number % loopCounter == 0)
                        return false;
                }
                return true;
            }
        }
    }
}
