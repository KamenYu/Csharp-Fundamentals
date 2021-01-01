using System;
using System.Linq;
using System.Collections.Generic;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCappacity = int.Parse(Console.ReadLine());

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split();

                if (tokens[0] == "Add")
                {
                    int addWagon = int.Parse(tokens[1]);
                    wagons.Add(addWagon);
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int number = int.Parse(tokens[0]);

                        if (wagons[i] < maxCappacity && wagons[i] + number <= maxCappacity)
                        {
                            wagons[i] += number;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(" ", wagons));
        }

    }
}
