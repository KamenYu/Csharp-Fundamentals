using System;
using System.Collections.Generic;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommnads = int.Parse(Console.ReadLine());

            List<string> guestList = new List<string>();

            // Allie is going
            // John is not going

            for (int i = 0; i < numberOfCommnads; i++)
            {
                string[] line = Console.ReadLine().Split();

                if (line[2] == "going!")
                {
                    if (guestList.Contains(line[0]))
                    {
                        Console.WriteLine($"{line[0]} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(line[0]);
                    }
                }
                else if (line[2] == "not")
                {
                    if (guestList.Contains(line[0]))
                    {
                        guestList.Remove(line[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{line[0]} is not in the list!");
                    }
                }
            }

            for (int i = 0; i < guestList.Count; i++)
            {
                Console.WriteLine(guestList[i]);
            }
        }
    }
}
