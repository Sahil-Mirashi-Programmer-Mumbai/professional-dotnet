// Program to demonstrate Private Access Modifier in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace PrivateAccessModifier_01
{
    class BankAccount
    {
        // Private field accessible only within the class 'BankAccount'
        private decimal _balance;

        // Public method to modify private field
        public void Deposit(decimal amount)
        {
            _balance += amount; // Modifying private field within the class 'BankAccount'
        }

        // Public method to display private field
        public void DisplayBalance()
        {
            Console.WriteLine($"Balance: {_balance}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate Private Access Modifier in C# with Visual Studio\n");

            BankAccount account = new BankAccount();
            account.Deposit(100.50M); // Using public method to modify private field

            // Using public method to display private field
            account.DisplayBalance(); // Output: Balance: 100.50
        }
    }
}
