using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that calculates the total price of an order and prints it on the console.
            //The method should receive one of the following products: coffee, coke, water, snacks;
            //and a quantity of the product. The prices for a single piece of each product are: 
            //coffee – 1.50
            //water – 1.00
            //coke – 1.40
            //snacks – 2.00
            //Print the result formatted to the second decimal place

            string good = Console.ReadLine();
            short amount = short.Parse(Console.ReadLine());
            OrderTaker(good, amount);
        }

        static void OrderTaker(string good, short amount)
        {
            double price = 0;
            switch (good)
            {
                case "coffee":
                    price = 1.5 * amount;
                    break;
                case "water":
                    price = 1.00 * amount;
                    break;
                case "coke":
                    price = 1.4 * amount;
                    break;
                case "snacks":
                    price = 2.00 * amount;
                    break;
            }
            Console.WriteLine($"{price:f2}"); 
        }
    } 
}
