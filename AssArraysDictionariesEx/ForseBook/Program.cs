using System;
using System.Linq;
using System.Collections.Generic;

namespace ForseBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, string> forceUsers = new Dictionary<string, string>();

            while (command != "Lumpawaroo")
            {
                string forceSide;
                string forceUser;

                if (command.Contains("|"))
                {
                    forceSide = command.Split(" | ", 2)[0];
                    forceUser = command.Split(" | ", 2)[1];

                    if (forceUsers.ContainsKey(forceUser) == false)
                    {
                        forceUsers.Add(forceUser, forceSide);
                    }                   
                }
                else
                {
                    forceSide = command.Split(" -> ", 2)[1];
                    forceUser = command.Split(" -> ", 2)[0];

                    if (forceUsers.ContainsKey(forceUser) == false)
                    {
                        forceUsers.Add(forceUser, forceSide);                       
                    }
                    else
                    {
                        forceUsers[forceUser] = forceSide;
                    }
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
                command = Console.ReadLine();
            }

            foreach (var item in forceUsers
                .GroupBy(x =>x.Value)
                .OrderByDescending(x =>x.Count())
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Count()}");

                foreach (var x in item.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"! {x.Key}");
                }
            }
        }
    }
}
