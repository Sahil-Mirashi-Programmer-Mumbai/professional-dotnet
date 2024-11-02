// Program to demonstrate Record with Immutable Properties and Methods in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace RecordWithImmutablePropertiesAndMethods_01
{
    // Defining a record named 'Car'.
    // Records can also contain methods along with properties.
    record Car(string Brand, string Model)
    {
        // Method to return car details as a string.
        public string GetCarDetails()
        {
            return $"Brand: {Brand} Model: {Model}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Record with Immutable Properties and Methods in C# with Visual Studio\n");

            // Creating an instance of 'Car' record.
            Car car = new("Honda", "Civic");

            // Displaying car details.
            Console.WriteLine(car.GetCarDetails()); // Output: Make: Honda, Model: Civic

        }
    }
}
