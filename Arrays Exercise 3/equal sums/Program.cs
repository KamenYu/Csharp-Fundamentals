using System;
using System.Linq;

namespace equal_sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // 1 2 4 5 7
            // if 1 == 4+5+7
            // if 1+2 == 5+7
            // if 1+2+4 == 7, if yes pring=t the index

            for (int i = 0; i < array.Length; i++)
            {
                int rightSum = 0;
                int leftSum = 0;

                for (int j = 0; j < i; j++)
                {
                    rightSum += array[j];
                }

                for (int k = i+1; k < array.Length; k++)
                {
                    leftSum += array[k];
                }

                if(rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
