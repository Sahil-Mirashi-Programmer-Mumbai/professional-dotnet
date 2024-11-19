// Program to demonstrate Converting Infix Expressions Postfix using Stack in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    This example converts infix mathematical expressions to postfix notation using a stack.
    Used in evaluating mathematical expressions by compilers and interpreters.
*/

namespace _10_ConvertingInfixExpressionsPostfixUsingStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Converting Infix Expressions to Postfix using Stack in C# with Visual Studio\n");

            string infix = "((A + B) - C * (D / E)) + F"; // The infix expression to be converted.
            string postfix = ConvertInfixToPostfix(infix); // Convert the infix expression to postfix notation.
            Console.WriteLine($"Infix: {infix}"); // Display the original infix expression.
            Console.WriteLine($"Postfix: {postfix}"); // Display the converted postfix expression.
        }

        // Method to convert an infix expression to postfix notation.
        static string ConvertInfixToPostfix(string infix)
        {
            Stack<char> stack = new Stack<char>(); // Initialize a stack to manage operators and parentheses.
            string postfix = string.Empty; // Initialize an empty string to build the postfix expression.

            // Define operator precedence using a dictionary.
            Dictionary<char, int> precedence = new Dictionary<char, int>
            {
                { '^', 3 }, // Exponentiation has the highest precedence.
                { '*', 2 }, // Multiplication has medium precedence.
                { '/', 2 }, // Division has the same precedence as multiplication.
                { '+', 1 }, // Addition has the lowest precedence.
                { '-', 1 }  // Subtraction has the same precedence as addition.
            };

            // Iterate over each character in the infix expression, ignoring spaces.
            foreach (char c in infix.Replace(" ", string.Empty))
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9') ) // Check if the character is a digit (operand).
                {
                    postfix += c; // Add operand directly to the postfix expression.
                }
                else if (c == '(') // Check if the character is an opening parenthesis.
                {
                    stack.Push(c); // Push opening parenthesis onto the stack.
                }
                else if (c == ')') // Check if the character is a closing parenthesis.
                {
                    // Pop operators from the stack until an opening parenthesis is encountered.
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        postfix += stack.Pop(); // Add each popped operator to the postfix expression.
                    }
                    stack.Pop(); // Remove the opening parenthesis from the stack.
                }
                else if (precedence.ContainsKey(c)) // Check if the character is an operator.
                {
                    // While there are operators on the stack with greater or equal precedence, pop them.
                    while (stack.Count > 0 && precedence.ContainsKey(stack.Peek()) &&
                           precedence[stack.Peek()] >= precedence[c])
                    {
                        postfix += stack.Pop(); // Add each popped operator to the postfix expression.
                    }
                    stack.Push(c); // Push the current operator onto the stack.
                }
            }

            // After processing all characters, pop any remaining operators from the stack.
            while (stack.Count > 0)
            {
                postfix += stack.Pop(); // Add each popped operator to the postfix expression.
            }

            return postfix; // Return the final postfix expression.
        }
    }
}