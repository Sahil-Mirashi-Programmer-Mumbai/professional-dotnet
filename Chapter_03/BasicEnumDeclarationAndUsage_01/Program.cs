// Program to demonstrate Basic Enum Declaration and Usage in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace BasicEnumDeclarationAndUsage_01
{
    // Declaring an enum type named 'DayOfWeek'.
    // An enum (short for "enumeration") is a distinct type that consists of a set of named constants called enumerators. 
    enum DayOfWeek
    {
        // Each named contant in enum has an underlying value starting from 0 by default
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Basic Enum Declaration and Usage in C# with Visual Studio\n");

            // Declaring a variable of type 'DayOfWeek' and assigning it a value from the enum.
            DayOfWeek today = DayOfWeek.Friday;

            // Displaying the value of the enum.
            Console.WriteLine($"Today is {today}");
        }
    }
}
