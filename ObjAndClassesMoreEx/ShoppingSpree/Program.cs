using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        public class Product
        {
            public string PName { get; set; }
            public double PCost { get; set; }
            public Product(string name, double cost)
            {
                PName = name;
                PCost = cost;
            }
        }

        public class Person
        {
            public string Name { get; set; }
            public double Money { get; set; }
            public List<string> Bag { get; set; } = new List<string>();

            public Person(string name, double money)
            {
                Name = name;
                Money = money;
            }

            public void PurchaseChecker(Product good)
            {
                if (Money >= good.PCost)
                {
                    Money -= good.PCost;
                    Console.WriteLine($"{Name} bought {good.PName}");
                    Bag.Add(good.PName);
                }
                else
                {
                    Console.WriteLine($"{Name} can't afford {good.PName}");
                }
            }
        }

        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries); //??
            List<Person> people = new List<Person>();

            for (int i = 0; i < names.Length; i++)
            {
                string[] tokens = names[i].Split('=');
                string name = tokens[0];
                double money = double.Parse(tokens[1]);
                Person person = new Person(name, money);
                people.Add(person);
            }

            List<Product> productList = new List<Product>();
            string[] products = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < products.Length; i++)
            {
                string[] tokens = products[i].Split('=');
                string name = tokens[0];
                double money = double.Parse(tokens[1]);
                Product product = new Product(name, money);
                productList.Add(product);
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                string name = command.Split()[0];
                string product = command.Split()[1];

                people.Find(p => p.Name == name).PurchaseChecker(productList.Find(p => p.PName == product));
            }

            foreach (var item in people)
            {
                if (item.Bag.Count == 0)
                {
                    Console.WriteLine($"{item.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{item.Name} - {string.Join(", ", item.Bag)}");
                }
            }
        }
    }
}