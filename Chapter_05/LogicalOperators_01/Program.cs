// Program to demonstrate Logical Operators in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace LogicalOperators_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Logical Operators in C# with Visual Studio\n");

            // Logical operators: && (AND), || (OR), ! (NOT)
            bool condition1 = true;
            bool condition2 = false;

            // Logical AND (&&) - true only if both operands are true
            bool resultAnd = condition1 && condition2;
            Console.WriteLine($"condition1 AND condition2: {resultAnd}");

            // Logical OR (||) - true if at least one operand is true
            bool resultOr = condition1 || condition2;
            Console.WriteLine($"condition1 OR condition2: {resultOr}");

            // Logical NOT (!) - negates the boolean value
            bool resultNot = !condition1;
            Console.WriteLine($"NOT condition1: {resultNot}");

            // Combining logical operators
            bool complexCondition = (5 > 3) && (10 < 20) || (2 == 2);
            Console.WriteLine($"Complex condition result: {complexCondition}");
        }
    }
}
