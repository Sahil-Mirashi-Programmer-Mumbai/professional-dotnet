// Program to demonstrate Enum and Switch Statements in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace EnumAndSwitchStatements_01
{
    // Enum named 'TrafficSignal' that represents different states of a traffic light.
    enum TrafficSignal
    {
        Red,
        Green,
        Yellow
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Enum and Switch Statements in C# with Visual Studio\n");

            // Assigning a value to 'TrafficSignal' enum variable.
            TrafficSignal trafficSignal = TrafficSignal.Red;

            // Using a switch statement to perform different actions based on the enum value.
            switch (trafficSignal)
            {
                case TrafficSignal.Red:
                    Console.WriteLine("Signal is Red");
                    break;
                case TrafficSignal.Green:
                    Console.WriteLine("Signal is Green");
                    break;
                case TrafficSignal.Yellow:
                    Console.WriteLine("Signal is Yellow");
                    break;
                default:
                    Console.WriteLine("Invalid Signal");
                    break;
            }
        }
    }
}
