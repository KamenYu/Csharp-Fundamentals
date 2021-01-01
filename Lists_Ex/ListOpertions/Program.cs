using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
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

            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split();
       
                switch (tokens[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        list.Add(numberToAdd);
                        break;

                    case "Remove":
                        int index = int.Parse(tokens[1]);
                        IndexOutOfRangeCheckerForRemove(list, index);                       
                        break;

                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        IndexOutOfRangeCheckerForInsert(list, indexToInsert, numberToInsert);
                        break;

                    case "Shift":
                        int rounds = int.Parse(tokens[2]);

                        if (tokens[1] == "left")
                        {                           
                            for (int i = 0; i < rounds; i++)
                            {
                                int temp = list[0];
                                list.Add(temp);
                                list.RemoveAt(0);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < rounds; i++)
                            {
                                int temp = list[list.Count - 1];            
                                list.Remove(list[list.Count - 1]);
                                list.Insert(0, temp);
                            }
                        }
                        break;
                }
            }
            Console.WriteLine(String.Join(" ", list));
        }

        static void IndexOutOfRangeCheckerForInsert(List<int> list, int index, int i)
        {
            if (index >= 0 && index < list.Count)
            {
                list.Insert(index, i);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }
        static void IndexOutOfRangeCheckerForRemove(List<int> list, int index)
        {
            if (index >= 0 && index < list.Count)
            {
                list.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }
        
    }
}

