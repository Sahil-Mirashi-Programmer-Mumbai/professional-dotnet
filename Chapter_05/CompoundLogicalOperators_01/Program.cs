// Program to demonstrate Compound Logical Operators in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace CompoundLogicalOperators_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Compound Logical Operators in C# with Visual Studio\n");

            // Combining multiple logical operators in a single expression
            int num1 = 12;
            int num2 = 15;

            // Logical AND (&&) and OR (||) used together
            bool isBetween = (num1 > 10) && (num1 < 20) || (num2 > 20);
            // Explanation:
            // (num1 > 10) is true
            // (num1 < 20) is true
            // (num2 > 20) is false
            // The expression evaluates as follows:
            // (true AND true) OR false => true OR false => true
            Console.WriteLine($"Is {num1} between 10 and 20, or is {num2} greater than 20? {isBetween}");

            // Parentheses can alter logical operation precedence
            bool alteredPrecedence = (num1 > 10) && ((num1 < 20) || (num2 > 20));
            // In this case, (num1 < 20) OR (num2 > 20) is evaluated first
            Console.WriteLine($"Is {num1} > 10 AND either < 20 OR {num2} > 20? {alteredPrecedence}");
        }
    }
}
