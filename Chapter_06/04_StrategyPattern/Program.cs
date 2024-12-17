/*
Definition: Strategy Pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from the clients that use it.

Why it is used: To allow clients to choose an algorithm from a family of algorithms at runtime.
*/

namespace StrategyPattern
{
    // Strategy Interface
    public interface IDiscountStrategy
    {
        double ApplyDiscount(double price);
    }

    // Concrete Strategy: No discount
    public class NoDiscountStrategy : IDiscountStrategy
    {
        public double ApplyDiscount(double price)
        {
            return price;
        }
    }

    // Concrete Strategy: 10% discount
    public class TenPercentDiscountStrategy : IDiscountStrategy
    {
        public double ApplyDiscount(double price)
        {
            return price * 0.9;
        }
    }

    // Context class
    public class ShoppingCart
    {
        private IDiscountStrategy _discountStrategy;

        // Set the discount strategy
        public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public double GetTotal(double price)
        {
            return _discountStrategy.ApplyDiscount(price);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            cart.SetDiscountStrategy(new TenPercentDiscountStrategy());
            Console.WriteLine("Total with discount: " + cart.GetTotal(100));  // Output: 90

            cart.SetDiscountStrategy(new NoDiscountStrategy());
            Console.WriteLine("Total without discount: " + cart.GetTotal(100));  // Output: 100
        }
    }
}