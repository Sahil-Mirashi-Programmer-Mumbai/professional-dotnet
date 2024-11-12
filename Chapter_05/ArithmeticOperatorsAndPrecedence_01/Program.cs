// Program to demonstrate Arithmetic Operators and Precedence in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace ArithmeticOperatorsAndPrecedence_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Arithmetic Operators and Precedence in C# with Visual Studio\n");

            // Arithmetic operators in C# include: +, -, *, /, %
            int a = 10; // Declare and initialize integer 'a'
            int b = 4;  // Declare and initialize integer 'b'

            // Addition
            int additionResult = a + b;
            Console.WriteLine($"Addition: {a} + {b} = {additionResult}");

            // Subtraction
            int subtractionResult = a - b;
            Console.WriteLine($"Subtraction: {a} - {b} = {subtractionResult}");

            // Multiplication
            int multiplicationResult = a * b;
            Console.WriteLine($"Multiplication: {a} * {b} = {multiplicationResult}");

            // Division (integer division truncates decimal part)
            int divisionResult = a / b;
            Console.WriteLine($"Division: {a} / {b} = {divisionResult}");

            // Modulus (remainder of division)
            int modulusResult = a % b;
            Console.WriteLine($"Modulus: {a} % {b} = {modulusResult}");

            // Operator precedence example: multiplication before addition
            int resultWithPrecedence = a + b * 2;
            // Equivalent to a + (b * 2) because * has higher precedence than +
            Console.WriteLine($"With precedence: {a} + {b} * 2 = {resultWithPrecedence}");

            // Use parentheses to change order of operations
            int resultWithParentheses = (a + b) * 2;
            Console.WriteLine($"With parentheses: ({a} + {b}) * 2 = {resultWithParentheses}");
        }
    }
}
