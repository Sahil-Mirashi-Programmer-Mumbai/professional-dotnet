/*
Program to demonstrate LINQ Reactive Extensions in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: LINQ integrates with Reactive Extensions for asynchronous event streams.
Application: Managing real-time streams like IoT data or user events.
*/

using System;
using System.Reactive.Linq;

namespace LINQReactiveExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate LINQ Reactive Extensions in C# with Visual Studio\n");

            // Creating an observable sequence
            var observable = Observable.Interval(TimeSpan.FromSeconds(1)).Take(5);

            // Subscribing to the observable with LINQ-like query
            observable.Subscribe(value => Console.WriteLine($"Received: {value}"));
        }
    }
}