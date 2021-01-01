using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {

            //Contains {number} – check if the list contains the number print "Yes",notherwise "No such number".
            //PrintEven – print all the even numbers, separated by a space.
            //PrintOdd – print all the odd numbers, separated by a space.
            //GetSum – print the sum of all the numbers.
            //Filter {condition} {number} – print all the numbers that fulfill the given condition - '<', '>', ">=", "<=".

            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;
            int counter = 0;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split();

                switch (tokens[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        list.Add(numberToAdd);
                        counter++;
                        break;

                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        list.Remove(numberToRemove);
                        counter++;
                        break;

                    case "RemoveAt":
                        counter++;
                        int indexToRemove = int.Parse(tokens[1]);
                        list.RemoveAt(indexToRemove);
                        break;

                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        list.Insert(indexToInsert, numberToInsert);
                        counter++;
                        break;

                    case "Contains":

                        int isContained = int.Parse(tokens[1]);

                        if (list.Contains(isContained) == true)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;

                    case "PrintEven":
                        List<int> evens = new List<int>();

                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] % 2 == 0)
                            {
                                evens.Add(list[i]);
                            }
                        }
                        Console.WriteLine(String.Join(" ", evens));
                        break;

                    case "PrintOdd":
                        List<int> odds = new List<int>();

                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] % 2 != 0)
                            {
                                odds.Add(list[i]);
                            }
                        }
                        Console.WriteLine(String.Join(" ", odds));
                        break;
                    case "GetSum":
                        Console.WriteLine(list.Sum());
                        break;

                    case "Filter":                        // List<int> filteredList = list.FindAll(x => x > number);
                        int number = int.Parse(tokens[2]);
                        string condition = tokens[1];

                        List<int> filtered = new List<int>();

                        if (condition == ">")
                        {
                            filtered = list.FindAll(x => x > number);
                        }
                        else if (condition == "<")
                        {
                            filtered = list.FindAll(x => x < number);
                        }
                        else if (condition == ">=")
                        {
                            filtered = list.FindAll(x => x >= number);
                        }
                        else if (condition == "<=")
                        {
                            filtered = list.FindAll(x => x <= number);
                        }

                        Console.WriteLine(String.Join(" ", filtered));                      
                        break;
                }
            }
            if (counter > 0)
            {
                Console.WriteLine(String.Join(" ", list));
            }           
        }
    }
}
