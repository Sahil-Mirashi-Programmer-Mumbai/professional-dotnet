// Program to demonstrate Lambdas in Custom Delegates in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Custom Delegates: Lambdas provide a convenient way to implement custom delegates.
    Concise and Flexible: Simplifies delegate instantiation.
    Reusability: Allows inline or reusable definitions.
*/

namespace LambdasInCustomDelegates_01
{
    // Custom delegate definition
    public delegate string Greet(string name);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Lambdas in Custom Delegates in C# with Visual Studio\n");

            // Using a lambda to define the behavior of the Greet delegate
            Greet greet = name => $"Hello, {name}!";

            // Invoking the lambda
            Console.WriteLine(greet("World")); // Output: Hello, World!
        }
    }
}