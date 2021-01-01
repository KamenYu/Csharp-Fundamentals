using System;

namespace vending_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double sumCoins = 0;

            while (command != "Start")
            {
                double coins = double.Parse(command);
                bool iscorrect = coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2;
                if (iscorrect == false)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                else
                {
                    sumCoins += coins;
                }
                command = Console.ReadLine();
            }
            string purchase = Console.ReadLine();

            //“Nuts”, “Water”, “Crisps”, “Soda”, “Coke”.
            //2.0,      0.7,     1.5,     0.8,    1.0
            
            while (purchase != "End")
            {
                double temp = sumCoins;
                switch (purchase)
                {
                    case "Nuts":
                        sumCoins -= 2.0;
                        break;
                    case "Water":
                        sumCoins -= 0.7;
                        break;
                    case "Crisps":
                        sumCoins -= 1.5;
                        break;
                    case "Soda":
                        sumCoins -= 0.8;
                        break;
                    case "Coke":
                        sumCoins -= 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                bool products = purchase == "Nuts" || purchase == "Water" || purchase == "Crisps" || purchase == "Soda" || purchase == "Coke";
                if (sumCoins < 0)
                {
                    sumCoins = temp;
                    Console.WriteLine("Sorry, not enough money");
                }
                else if (products)
                {
                    Console.WriteLine($"Purchased {purchase.ToLower()}");
                }
                purchase = Console.ReadLine();
            }                     
            Console.WriteLine($"Change: {sumCoins:f2}"); 
        }
    }
}
