// Program to demonstrate Relational Operators in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace RelationalOperators_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Relational Operators in C# with Visual Studio\n");

            // Relational operators compare two values and return a boolean result
            int x = 10;
            int y = 15;

            // '>' operator: greater than
            bool isGreater = x > y;
            Console.WriteLine($"{x} > {y}: {isGreater}");

            // '<' operator: less than
            bool isLess = x < y;
            Console.WriteLine($"{x} < {y}: {isLess}");

            // '>=' operator: greater than or equal to
            bool isGreaterOrEqual = x >= 10;
            Console.WriteLine($"{x} >= 10: {isGreaterOrEqual}");

            // '<=' operator: less than or equal to
            bool isLessOrEqual = y <= 20;
            Console.WriteLine($"{y} <= 20: {isLessOrEqual}");

            // '==' operator: equality comparison
            bool isEqual = x == y;
            Console.WriteLine($"{x} == {y}: {isEqual}");

            // '!=' operator: inequality comparison
            bool isNotEqual = x != y;
            Console.WriteLine($"{x} != {y}: {isNotEqual}");
        }
    }
}
