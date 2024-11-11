// Program to demonstrate Palindrome Check in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace PalindromeCheck_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Palindrome Check in C# with Visual Studio\n");

            Console.Write("Enter input: ");

            string? input = Console.ReadLine();

            if (IsPalindrome(input))
            {
                Console.WriteLine("Is a Palindrome");
            }
            else
            {
                Console.WriteLine("Is not a Palindrome");
            }
        }

        static bool IsPalindrome(string input)
        {
            int length = input.Length;

            for (int loopCounter = 0; loopCounter < length / 2; loopCounter++)
            {
                if(input[loopCounter] != input[length - loopCounter - 1])
                    return false;
            }
            return true;
        }
    }
}
