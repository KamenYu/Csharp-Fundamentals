using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            // Regex reg = new Regex(@">>(?<fur>[A-Za-z]+)<<(?<price>\d+\.?\d*)!(?<amount>\d+)");
            Regex reg = new Regex(@">>(?<fur>[A-Za-z]+)<<(?<price>\d+|(?:\d+\.\d+))!(?<amount>\d+)"); // this is mine
            List<string> furnitureList = new List<string>();
            double total = 0;

            while (input != "Purchase")
            {                
                Match furnitureInfo = reg.Match(input);

                if (furnitureInfo.Success)
                {
                    furnitureList.Add(furnitureInfo.Groups[1].Value);
                    total += (double.Parse(furnitureInfo.Groups["price"].Value) * int.Parse(furnitureInfo.Groups["amount"].Value));
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            if (total > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, furnitureList));
            }            
            Console.WriteLine($"Total money spend: {total:f2}");
        }
    }
}