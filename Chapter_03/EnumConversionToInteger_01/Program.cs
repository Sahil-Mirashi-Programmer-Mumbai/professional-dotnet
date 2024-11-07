// Program to demonstrate Enum Conversion to Integer in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace EnumConversionToInteger_01
{
    // Enum named 'OrderStatus' to represent different stages of an order's lifecycle.
    // Enum values are implicitly assigned starting from 0.
    enum OrderStatus
    {
        Placed, // 0
        Processing, // 1
        Shipping, // 2
        Delivered // 3
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Enum Conversion to Integer in C# with Visual Studio\n");

            // Assigning an enum value to 'OrderStatus'.
            OrderStatus status = OrderStatus.Shipping;

            // Converting the enum value to its underlying integer.
            int status_code = (int)status;

            // Displaying the integer value of the enum.
            Console.WriteLine($"Status Code: {status_code}");
        }
    }
}
