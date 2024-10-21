// Program to demonstrate method overloading in C# with Visual Studio
// Programmer: Sahil Mirashi

public class Calculator
{
    // Method to add two integers
    public int Add(int a, int b)
    {
        Console.WriteLine("Implementation of Add() method with two parameters");

        return a + b;
    }

    // Overloaded method to add three integers
    public int Add(int a, int b, int c)
    {
        Console.WriteLine("Implementation of Add() method with three parameters");

        return a + b + c;
    }
}

namespace MethodOverloading_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate method overloading in C# with Visual Studio\n");

            Calculator calc = new Calculator();
            
            Console.WriteLine(calc.Add(5, 3));       // Output: 8
            Console.WriteLine(calc.Add(5, 3, 2));    // Output: 10
        }
    }
}
