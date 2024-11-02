// Program to demonstrate Enum Conversion to Integer in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace EnumConversionToInteger_01
{
    // Enum named 'OrderStatus' to represent different stages of an order's lifecycle.
    // Enum values are implicitly assigned starting from 0.
    enum OrderStatus
    {
        Pending,
        Processing,
        Dispatched,
        Delivered
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Enum Conversion to Integer in C# with Visual Studio\n");

            // Assigning an enum value to 'OrderStatus'.
            OrderStatus status = OrderStatus.Processing;

            // Converting the enum value to its underlying integer.
            int statusCode = (int)status;

            // Displaying the integer value of the enum.
            Console.WriteLine($"Order Status Code: {statusCode}");
        }
    }
}
