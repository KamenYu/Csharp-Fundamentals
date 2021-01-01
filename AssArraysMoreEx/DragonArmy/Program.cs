using System;
using System.Collections.Generic;
using System.Linq;

namespace DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<int>>> dragonLog = new Dictionary<string, Dictionary<string, List<int>>>();
            // health 250, damage 45, and armor 10
            for (byte i = 0; i < n; i++)
            {                                                // {type}   {name}     {damage} {health} {armor}
                string[] input = Console.ReadLine().Split(); // Red     Bazgargal    100       2500     25
                string type = input[0];
                string name = input[1];
                if (input[2] == "null")
                {
                    input[2] = "45";
                }
                if (input[3] == "null")
                {
                    input[3] = "250";
                }
                if (input[4] == "null")
                {
                    input[4] = "10";
                }
                int damage = int.Parse(input[2]);
                int hp = int.Parse(input[3]);
                int armor = int.Parse(input[4]);
                
                if (dragonLog.ContainsKey(type))
                {
                    if (dragonLog[type].ContainsKey(name))
                    {
                        dragonLog[type][name][0] = damage;
                        dragonLog[type][name][1] = hp;
                        dragonLog[type][name][2] = armor;
                    }
                    else
                    {
                        dragonLog[type].Add(name, new List<int>() { damage, hp, armor });
                    }
                    
                }
                else
                {
                    dragonLog.Add(type, new Dictionary<string, List<int>>());
                    dragonLog[type].Add(name, new List<int>() { damage, hp, armor });
                }
            }
            double avDamage = 0;
            double avHP = 0;
            double avArmor = 0;
            int count = 0;

            Dictionary<string, List<double>> averaged = new Dictionary<string, List<double>>();
            foreach (var type in dragonLog)
            {
                foreach (var item in type.Value)
                {
                    avDamage += item.Value[0];
                    avHP += item.Value[1];
                    avArmor += item.Value[2];
                    count++;
                }
                if (count == 0)
                {
                    count = 1;
                }
                avDamage /= count;
                avHP /= count;
                avArmor /= count;
                count = 0;

                averaged.Add(type.Key, new List<double>() { avDamage, avHP, avArmor });

                avArmor = 0;
                avDamage = 0;
                avHP = 0;
            }

            foreach (var item in averaged)
            {
                Console.WriteLine($"{item.Key}::({item.Value[0]:f2}/{item.Value[1]:f2}/{item.Value[2]:f2})");
                                    
                foreach (var it in dragonLog[item.Key].OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{it.Key} -> damage: {it.Value[0]}, health: {it.Value[1]}, armor: {it.Value[2]}");
                }                
            }            
        }
    }
}
