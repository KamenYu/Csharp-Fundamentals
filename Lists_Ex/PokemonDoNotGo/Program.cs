using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDoNotGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()     
                .Split()
                .Select(int.Parse)
                .ToList();

            int index = int.Parse(Console.ReadLine());    // 2

            // 5 13 17 40
            // 0  1  2  3

            int removedElement = 0;
            int sum = 0;
            while (input.Count != 0)
            {                
                if (index >= 0 && index <= input.Count - 1)
                {
                    removedElement = input[index];   // 17
                    input.RemoveAt(index);           // 5 13 40
                    IncreaseAndDecreaseSequence(input, removedElement);
                }
                else if (index < 0)        // 22 30 23, index = -1
                {
                    removedElement = input[0];
                    input.RemoveAt(0);
                    int lastToFirst = input[input.Count - 1];
                    input.Insert(0, lastToFirst);
                    IncreaseAndDecreaseSequence(input, removedElement);
                }
                else if (index > input.Count - 1)
                {
                    removedElement = input[input.Count - 1];
                    input.RemoveAt(input.Count - 1);
                    input.Add(input[0]);
                    IncreaseAndDecreaseSequence(input, removedElement);                   
                }
                sum += removedElement;
                if (input.Count == 0)
                {
                    break;
                }
                index = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }

        static void IncreaseAndDecreaseSequence(List<int> list, int num)
        {
            for (int i = 0; i <= list.Count - 1; i++)
            {
                if (list[i] <= num)
                {
                    list[i] += num;
                }
                else
                {
                    list[i] -= num;
                }
            }
        }       
    }
}
