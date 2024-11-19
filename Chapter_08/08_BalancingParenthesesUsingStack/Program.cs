// Program to demonstrate Balancing Parentheses using Stack in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    This example uses a stack to check if an expression's parentheses are balanced.
    Demonstrates practical applications of stacks in syntax validation and parsing.
    Widely used in compilers, interpreters, and code editors.
*/

namespace _08_BalancingParenthesesUsingStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Balancing Parentheses using Stack in C# with Visual Studio\n");

            string expression = "(5 + (3 * 2) - (8 / 4))";
            bool isBalanced = CheckBalancedParentheses(expression);

            Console.WriteLine($"The expression \"{expression}\" is " + (isBalanced ? "balanced" : "not balanced"));
        }

        static bool CheckBalancedParentheses(string expression)
        {
            // Create a stack to keep track of opening parentheses
            Stack<char> stack = new Stack<char>();

            // Loop through each character in the string
            foreach (char c in expression)
            {
                // If an opening parenthesis is encountered, push it onto the stack
                if (c == '(')
                {
                    stack.Push(c);
                }
                // If a closing parenthesis is encountered
                else if (c == ')')
                {
                    // If the stack is empty, it means there is no matching opening parenthesis
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    // Pop the matching opening parenthesis from the stack
                    stack.Pop();
                }
            }

            // If the stack is empty, all parentheses are balanced
            return stack.Count == 0;
        }
    }
}