// Program to demonstrate Conditional Operator in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace ConditionalOperator_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Conditional Operator in C# with Visual Studio\n");

            // The conditional operator (ternary operator) evaluates a boolean expression and returns one of two values
            // Syntax: condition ? valueIfTrue : valueIfFalse
            int age = 20;

            // Using the ternary operator to determine if the person is an adult
            string result = (age >= 18) ? "Adult" : "Minor";
            // If 'age' is greater than or equal to 18, result is "Adult"; otherwise, result is "Minor"
            Console.WriteLine($"Age {age}: {result}");

            // Another example using ternary operator for even-odd check
            int number = 10;
            string evenOrOdd = (number % 2 == 0) ? "Even" : "Odd";
            // If 'number % 2' equals 0, then 'evenOrOdd' will be "Even"; otherwise, "Odd"
            Console.WriteLine($"{number} is {evenOrOdd}");
        }
    }
}
