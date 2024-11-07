// Program to demonstrate Custom Generic Exception Handling in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace CustomGenericExceptionHandling_01
{
    // Generic class for handling exceptions
    class ExceptionHandler<T> where T : Exception
    {
        public void Handle(T exception)
        {
            Console.WriteLine($"Handling: {typeof(T).Name} Exception Message: {exception.Message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Custom Generic Exception Handling in C# with Visual Studio\n");

            // Demonstrating the use of ExceptionHandler with different exception types
            ExceptionHandler<NullReferenceException> nullReferenceException = new ExceptionHandler<NullReferenceException>();
            nullReferenceException.Handle(new NullReferenceException("Null Reference Exception"));

            ExceptionHandler<InvalidOperationException> invalidOperationException = new ExceptionHandler<InvalidOperationException>();
            invalidOperationException.Handle(new InvalidOperationException("Invalid Operation Exception"));
        }
    }
}
