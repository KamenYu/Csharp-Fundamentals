using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> roster = new Dictionary<string, List<double>>();
            string command = Console.ReadLine();

            while (command != "buy")
            {
                string[] order = command.Split();
                string productName = order[0];
                double productPrice = double.Parse(order[1]);
                double productQuantity = double.Parse(order[2]);

                if (!roster.ContainsKey(productName))
                {
                    roster.Add(productName, new List<double> { productPrice, productQuantity });
                }
                else
                {
                    roster[productName][0] = productPrice;
                    roster[productName][1] += productQuantity;
                }
                command = Console.ReadLine();
            }

            foreach (var item in roster)
            {
                double totalPrice = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {totalPrice:f2}");
            }
        }
    }
}
