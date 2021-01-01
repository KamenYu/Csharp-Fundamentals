using System;
using System.Linq;
using System.Collections.Generic;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            // shards       ,    fragments,    motes
            // Shadowmourne      Valanyr       Dragonwrath

            string[] initialResources = Console.ReadLine().ToLower().Split();

            Dictionary<string, int> resourceLog = new Dictionary<string, int>();

            string resource = string.Empty;
            int q = 0;
            string shards = "shards";
            string fragments = "fragments";
            string motes = "motes";
            int counter = 0;
            while (true)
            {
                for (int i = 0; i < initialResources.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        q = int.Parse(initialResources[i]);
                    }
                    else
                    {
                        resource = initialResources[i];
                    }

                    if (i % 2 == 1)
                    {
                        if (resourceLog.ContainsKey(resource))
                        {
                            resourceLog[resource] += q;
                        }
                        else
                        {
                            resourceLog.Add(resource, q);
                        }
                    }

                    if (resourceLog.ContainsKey("shards") && resourceLog[shards] >= 250)  // FALSE
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                        resourceLog[shards] -= 250;
                        counter++;
                        break;
                    }
                    else if (resourceLog.ContainsKey("fragments") && resourceLog[fragments] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained!");
                        resourceLog[fragments] -= 250;
                        counter++;
                        break;
                    }
                    else if (resourceLog.ContainsKey("motes") && resourceLog[motes] >= 250)
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        resourceLog[motes] -= 250;
                        counter++;
                        break;
                    }
                }
                if (counter == 1)
                {
                    break;
                }
                initialResources = Console.ReadLine().ToLower().Split();
            }

            Dictionary<string, int> keyResources = new Dictionary<string, int>();

            if (resourceLog.ContainsKey(motes))
            {
                keyResources.Add("motes", resourceLog["motes"]);
            }
            else
            {
                keyResources.Add("motes", 0);
            }

            if (resourceLog.ContainsKey(shards))
            {
                keyResources.Add("shards", resourceLog["shards"]);
            }
            else
            {
                keyResources.Add("shards", 0);
            }

            if (resourceLog.ContainsKey(fragments))
            {
                keyResources.Add("fragments", resourceLog["fragments"]);
            }
            else
            {
                keyResources.Add("fragments", 0);
            }

            foreach (var item in keyResources.
                OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            resourceLog.Remove(shards);
            resourceLog.Remove(motes);
            resourceLog.Remove(fragments);

            foreach (var item in resourceLog.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}