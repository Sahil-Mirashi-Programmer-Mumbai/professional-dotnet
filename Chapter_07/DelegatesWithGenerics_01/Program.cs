// Program to demonstrate Delegates with Generics in C# with Visual Studio
// Programmer: Sahil Mirashi

/*
    Generic Delegates: Allow type flexibility.
    Generic Methods: Enhance code reusability.
*/

namespace DelegatesWithGenerics_01
{
    // Generic delegate definition
    public delegate T GenericCalculate<T>(T firstVariable, T secondVariable);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Delegates with Generics in C# with Visual Studio\n");

            GenericCalculate<int> addInteger = (int firstInteger, int secondInteger) => firstInteger + secondInteger;
            GenericCalculate<double> addDouble = (double firstDouble, double secondDouble) => firstDouble + secondDouble;

            Console.WriteLine($"Sum of integer: {addInteger(5, 7)}");
            Console.WriteLine($"Sum of double: {addDouble(5.5D, 7.9D)}");
        }
    }
}
