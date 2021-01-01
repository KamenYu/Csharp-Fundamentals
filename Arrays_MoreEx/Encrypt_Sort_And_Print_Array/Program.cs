using System;

namespace Encrypt_Sort_And_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] unsorted = new int[n];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string vowels = "EeUuIiOoAa";
                int sumV = 0;
                int sumC = 0;
                
                for (int j = 0; j < input.Length; j++)
                {
                    char currentLetter = input[j];
                    if (vowels.Contains(currentLetter))
                    {
                        sumV += input[j] * input.Length;
                    }
                    else
                    {
                        sumC += input[j] / input.Length;
                    }
                }

                int sum = sumC + sumV;
                unsorted[i] = sum;
            }

            Array.Sort(unsorted);

            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.WriteLine(unsorted[i]);
            }
        }
    }
}
