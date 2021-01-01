using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowhite
{
    class Program
    {
        static void Main(string[] args)
        {
            // {dwarfName} <:> {dwarfHatColor} <:> {dwarfPhysics}

            string input = string.Empty;
            Dictionary<string, Dictionary<string, int>> dwarfLog = new Dictionary<string, Dictionary<string, int>>();

            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] tokens = input.Split(" <:> ");
                string name = tokens[0];
                string hatColour = tokens[1];
                int physics = int.Parse(tokens[2]);

                if (dwarfLog.ContainsKey(hatColour))
                {
                    if (dwarfLog[hatColour].ContainsKey(name))
                    {
                        if (dwarfLog[hatColour][name] < physics)
                        {
                            dwarfLog[hatColour][name] = physics;
                        }
                    }
                    else
                    {
                        dwarfLog[hatColour].Add(name, physics);
                    }
                }
                else
                {
                    dwarfLog.Add(hatColour, new Dictionary<string, int>());
                    dwarfLog[hatColour].Add(name, physics);
                }
            }

            Dictionary<string, int> sorted = new Dictionary<string, int>();

            foreach (var colour in dwarfLog.OrderByDescending(x => x.Value.Count()))
            {
                foreach (var dwarf in colour.Value)
                {
                    sorted.Add($"({colour.Key}) {dwarf.Key} <->", dwarf.Value);
                }
            }

            foreach (var dwarf in sorted.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{dwarf.Key} {dwarf.Value}");
            }
        }
    }
}
