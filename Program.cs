using System;

namespace CoffeeShopApp
{
    public class CoffeeShop
    {
        private double coffeePrice;
        private double sandwichPrice;

        public CoffeeShop(double coffeePrice, double sandwichPrice)
        {
            this.coffeePrice = coffeePrice;
            this.sandwichPrice = sandwichPrice;
        }

        public double CalculateTotal(bool wantsCoffee, bool wantsSandwich)
        {
            double total = 0;
            if (wantsCoffee) total += coffeePrice;
            if (wantsSandwich) total += sandwichPrice;
            return total;
        }

        public void ProcessOrder(string customerName, bool wantsCoffee, bool wantsSandwich)
        {
            Console.WriteLine($"Processing order for {customerName}...");
            double total = CalculateTotal(wantsCoffee, wantsSandwich);
            Console.WriteLine($"Total to pay: ${total:F2}");
            ProcessPayment(total);
        }

        private void ProcessPayment(double amount)
        {
            Console.WriteLine($"Payment of ${amount:F2} processed. Thank you!");
        }

        public void UpdateMenu(double newCoffeePrice, double newSandwichPrice)
        {
            coffeePrice = newCoffeePrice;
            sandwichPrice = newSandwichPrice;
            Console.WriteLine("Menu updated.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize the Coffee Shop with default prices
            CoffeeShop coffeeShop = new CoffeeShop(4.0, 6.0);

            Console.WriteLine("Welcome to the Coffee Shop Application");

            // Process the first order
            coffeeShop.ProcessOrder("Faizan", wantsCoffee: true, wantsSandwich: false);

            // Update menu prices
            coffeeShop.UpdateMenu(5.0, 7.0);

            // Process the second order
            coffeeShop.ProcessOrder("Ali", wantsCoffee: true, wantsSandwich: true);

            Console.WriteLine("Thank you for visiting!");
        }
    }
}
