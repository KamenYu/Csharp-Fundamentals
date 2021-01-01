using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            // {Serial Number} {Item Name} {Item Quantity} {itemPrice}
            List<string> input = Console.ReadLine().Split().ToList();

            List<Box> boxes = new List<Box>();

            while (input[0] != "end")
            {
                string serialNumber = input[0];
                string itemName = input[1];
                int itemQuantity = int.Parse(input[2]);
                decimal itemPrice = decimal.Parse(input[3]);

                Box box = new Box();

                box.SerialNumber = serialNumber;
                box.ItemQuantity = itemQuantity;
                box.BoxPrice = itemQuantity * itemPrice;

                box.BoxItem = new Item() {Name=itemName, Price= itemPrice };

                boxes.Add(box);
                input = Console.ReadLine().Split().ToList();
            }

            Console.WriteLine(String.Join(Environment.NewLine, boxes.OrderByDescending(x => x.BoxPrice)));
        }


        public class Item
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
        }

        public class Box
        {
            public string SerialNumber { get; set; }
            public Item BoxItem { get; set; }
            public int ItemQuantity { get; set; }
            public decimal BoxPrice { get; set; }

            public override string ToString()
            {
                return $"{SerialNumber}\n-- { BoxItem.Name} - ${ BoxItem.Price:f2}: {ItemQuantity}\n-- ${BoxPrice:f2}";
            }
        }
    }  
}
