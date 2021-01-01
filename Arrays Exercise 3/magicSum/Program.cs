using System;
using System.Linq;

namespace magicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seq = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int magicNum = int.Parse(Console.ReadLine());
             
            // 1 7 6 2 19 23      magNum = 8

            for (int i = 0; i < seq.Length; i++)
            {
                for (int j = i + 1; j < seq.Length; j++)     // j = i +1 to forget the prevoius element
                {
                    if (seq[i] + seq[j] == magicNum)
                    {
                        Console.WriteLine($"{seq[i]} {seq[j]}");
                    }
                }               
            }
        }
    }
}
