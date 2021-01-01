using System;
using System.Linq;

namespace sortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int max = 0;
            int mid = 0;
            int min = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] < max && arr[j] > min)
                    {
                        mid = arr[j];
                    }
                    for (int k = 0; k < arr.Length; k++)
                    {
                        if (arr[k] < mid)
                        {
                            min = arr[k];
                        }
                    }
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(mid);
            Console.WriteLine(min);
        }
    }
}
