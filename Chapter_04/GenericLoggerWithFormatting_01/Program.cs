// Program to demonstrate Generic Logger With Formatting in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace GenericLoggerWithFormatting_01
{
    class Logger<T>
    {
        public void Log(T message)
        {
            Console.WriteLine($"Datetime: {DateTime.Now} Type: {typeof(T).Name} Message: {message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Generic Logger With Formatting in C# with Visual Studio\n");

            // Integer logging
            Logger<int> intLogger = new Logger<int>();
            intLogger.Log(25);

            // String logging
            Logger<string> stringLogger = new Logger<string>();
            stringLogger.Log("Hello");

            // Custom logging
            Logger<Exception> exceptionLogger = new Logger<Exception>();
            exceptionLogger.Log(new ArgumentException("Argument Exception"));
        }
    }
}
