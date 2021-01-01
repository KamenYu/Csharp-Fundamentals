using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split();

                switch (tokens[0])
                {
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        list.Insert(indexToInsert, numberToInsert);
                        break;
                    case "Delete":
                        int numToDelete = int.Parse(tokens[1]);
                        list.RemoveAll(x => x == numToDelete);
                        break;
                }
            }
            Console.WriteLine(String.Join(" ", list));
        }
    }
}


