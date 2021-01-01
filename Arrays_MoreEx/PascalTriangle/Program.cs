using System;
//using System.Collections.Generic;
using System.Linq;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[] { 0, 1, 0 };
            Console.WriteLine(1);
            for (int i = 1; i < n; i++)
            {               
                int[] newArr = new int[arr.Length + 1];

                for (int j = 0; j < newArr.Length; j++)
                {
                    if (j > 0 && j <= arr.Length - 1)
                    {
                        newArr[j] = arr[j] + arr[j - 1];
                    }
                    else
                    {
                        newArr[j] = 0;
                    }
                }
                Console.WriteLine(string.Join(' ', newArr.Where(x => x != 0)).ToArray());               
                arr = newArr.ToArray();
                //List<int> toPrint = arr.ToList();
                //toPrint.RemoveAll(x => x == 0);
            }
        }
    }
}