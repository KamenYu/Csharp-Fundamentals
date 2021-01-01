using System;

namespace CondenseArraysToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strint = Console.ReadLine().Split();
            int[] whole = new int[strint.Length];
            for (int i = 0; i < strint.Length; i++)
            {
                whole[i] = int.Parse(strint[i]);
            }

            // int temp = whole.Length - 1;
            while (whole.Length != 1)
            {
                int[] condensed = new int[whole.Length-1];

                for (int i = 0; i < condensed.Length; i++)
                {              
                    condensed[i] = whole[i] + whole[i + 1];
                }
                whole = condensed;
            }
         
            Console.WriteLine(String.Join(" ", whole));
        }
    }
}
