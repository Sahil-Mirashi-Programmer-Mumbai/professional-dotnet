// Program to demonstrate Generic Methods In Non Generic Class in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Swap<T> is a generic method where T represents the data type of the parameters.
    The method uses ref to modify the values of a and b outside the method scope.
    The main program shows the method swapping integers and strings.
    Application: Generic methods like this are useful when a function is meant to handle multiple data types without redundancy.
*/

namespace GenericMethodsInNonGenericClass_01
{
    class Utilities
    {
        // Generic method to swap two variables of type T
        public void Swap<T>(ref T firstVariable, ref T secondVariable)
        {
            T tempVariable = firstVariable; // Store value of firstVariable in tempVariable
            firstVariable = secondVariable; // Store value of secondVariable in firstVariable
            secondVariable = tempVariable; // Store value of tempVariable in secondVariable
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Generic Methods In Non Generic Class in C# with Visual Studio\n");

            Utilities utilities = new Utilities();

            int first_number = 10;
            int second_number = 20;

            Console.WriteLine($"Before swapping First Number: {first_number} Second Number: {second_number}");
            utilities.Swap(ref first_number, ref second_number);
            Console.WriteLine($"After swapping First Number: {first_number} Second Number: {second_number}");

            string first_string = "Hello";
            string second_string = "World";

            Console.WriteLine($"Before swapping First String: {first_string} Second String: {second_string}");
            utilities.Swap(ref first_string, ref second_string);
            Console.WriteLine($"After swapping First String: {first_string} Second String: {second_string}");
        }
    }
}
