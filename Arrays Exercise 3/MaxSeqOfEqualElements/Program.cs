using System;
using System.Linq;

namespace MaxSeqOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // 0 1 1 1 2 2 3 3 3 3

            int max = 0;
            int length = 1;

            int start = 0;
            int bestStart = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if(arr[i] == arr[i - 1])
                {
                    length++;
                }
                else
                {
                    length = 1;
                    start = i;
                }

                if(length > max)
                {
                    max = length;
                    bestStart = start;
                }
            }
            for (int i = bestStart; i < bestStart + max; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
