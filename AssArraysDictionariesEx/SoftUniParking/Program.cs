using System;
using System.Collections.Generic;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> registered = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                string userName = command[1];
                

                if (command[0] == "register")
                {
                    string licensePlate = command[2];

                    if (registered.ContainsKey(userName) == false)
                    {
                        registered.Add(userName, licensePlate);
                        Console.WriteLine($"{userName} registered {licensePlate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                    }
                }
                else
                {
                    if(registered.ContainsKey(userName) == false)
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                    registered.Remove(userName);
                }
            }

            foreach (var item in registered)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
