// Program to demonstrate Basic Closure in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Explanation:
    - A *closure* is a function that "remembers" the environment in which it was created.
    - In this example, 'CreateAdder' returns a function (lambda expression) that adds 'valueToAdd' to its input.
    - The returned lambda function "remembers" the value of 'valueToAdd', demonstrating the concept of closures.
 */

namespace BasicClosure_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Basic Closure in C# with Visual Studio\n");

            // Function demonstrating a simple closure
            Func<int, int> addValue = CreateAdder(10); // 'CreateAdder' returns a function that remembers the value 10
            Console.WriteLine(addValue(5)); // Output: 15
        }

        // Function that returns another function (closure) that "remembers" the value of 'valueToAdd'
        static Func<int, int> CreateAdder(int valueToAdd)
        {
            // Closure captures 'valueToAdd'
            return x => x + valueToAdd; // This lambda function closes over 'valueToAdd'
        }
    }
}