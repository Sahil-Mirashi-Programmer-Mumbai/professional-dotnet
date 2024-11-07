// Program to demonstrate Enum with Custom Values in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace EnumWithCustomValues_01
{
    // Declaring an enum named 'StatusCode' with custom integer values.
    // Enum values can be explicitly assigned, allowing custom values instead of the default sequence.
    enum StatusCode
    {
        Success = 100,
        Warning = 200,
        Error = 500,
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Enum with Custom Values in C# with Visual Studio\n");

            // Creating a variable of 'StatusCode' and setting it to a specific value.
            StatusCode status = StatusCode.Success;

            // Checking the value of the enum using a conditional statement.
            if(status == StatusCode.Success)
            {
                Console.WriteLine($"Status: {status} Status Code: {(int)status}"); // Status: Success Status Code: 100
            }
        }
    }
}
