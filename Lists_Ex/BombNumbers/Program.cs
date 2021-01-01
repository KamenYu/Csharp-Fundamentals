using System;
using System.Linq;
using System.Collections.Generic;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Your task is to detonate every occurrence of the special bomb number
            //and according to its power -his neighbors from left and right.
            //Detonations are performed from left to right and all detonated numbers disappear.
            //Finally print the sum of the remaining elements in the sequence.

            //  1 2 4 2 3 5 4 6 ->
            // num 4, pow 1
            //  -> 1 3

            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] numberAndPower = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rounds = (numberAndPower[1] * 2) + 1;

            //1 4 4 2 8 9 1
            //9 3
            int indexOfBomb = list.IndexOf(numberAndPower[0]);

            while (indexOfBomb != -1)
            {
                int leftN = indexOfBomb - numberAndPower[1];
                int rightN = indexOfBomb + numberAndPower[1];

                if (leftN < 0)
                {
                    leftN = 0;
                }
                if (rightN > list.Count - 1)
                {
                    rightN = list.Count - 1;
                }

                list.RemoveRange(leftN, rightN - leftN + 1);

                indexOfBomb = list.IndexOf(numberAndPower[0]);
            }

            Console.WriteLine(list.Sum());
        }
    }
}
