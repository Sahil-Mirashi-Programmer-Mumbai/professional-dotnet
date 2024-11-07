// Program to demonstrate Record with Immutable Properties and Methods in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace RecordWithImmutablePropertiesAndMethods_01
{
    // Defining a record named 'Car'.
    // Records can also contain methods along with properties.
    record Car(string Name, string Model)
    {
        public string GetCarDetails()
        {
            return $"Name: {Name} Model: {Model}";
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Record with Immutable Properties and Methods in C# with Visual Studio\n");

            // Creating an instance of 'Car' record.
            Car car = new Car("Honda", "Accord");

            // Displaying car details.
            Console.WriteLine($"{car.GetCarDetails()}"); // Output: Name: Honda Model: Accord
        }
    }
}
