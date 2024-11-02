// Program to demonstrate using out with TryParse method in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace UsingOutWithTryParseMethod_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate using out with TryParse method in C# with Visual Studio\n");

            string number = "777";
            int parsed_number;

            // TryParse uses out to return parsed number or default value zero
            if(int.TryParse(number, out parsed_number))
            {
                Console.WriteLine($"Parsed number: {parsed_number}"); // Output: Parsed number: 777
            }
            else
            {
                Console.WriteLine("Failed to parse"); // Output: Failed to parse
            }

        }
    }
}
