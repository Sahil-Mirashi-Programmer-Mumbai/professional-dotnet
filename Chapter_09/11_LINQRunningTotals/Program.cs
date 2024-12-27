/*
Program to demonstrate LINQ Running Totals in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: LINQ's Select and Aggregate allow creating derived data like running totals.
Application: Useful in financial reports or data visualizations requiring cumulative values.
*/

namespace LINQRunningTotals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate LINQ Running Totals in C# with Visual Studio\n");

            // List of numbers representing daily sales
            List<int> dailySales = new List<int> { 100, 200, 150, 300, 250 };

            // Calculating running totals using LINQ and Aggregate
            var runningTotals = dailySales.Select((sales, index) => dailySales.Take(index + 1).Sum());

            Console.WriteLine("Running Totals:");
            foreach (var total in runningTotals)
            {
                Console.WriteLine(total);
            }
        }
    }
}