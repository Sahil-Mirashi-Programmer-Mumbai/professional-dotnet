namespace Reverse_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Reverse in C# with Visual Studio\n");

            Console.Write("Enter input: ");
            string? input = Console.ReadLine();

            if(string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Please enter a valid input");
            }
            else
            {
                Console.WriteLine($"Reversed: {Reverse(input)}");
            }
        }

        static string Reverse(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
