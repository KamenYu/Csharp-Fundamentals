using System;
using System.Collections.Generic;
using System.Linq;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);   // A46b c8012x
            List<double> sums = new List<double>();
            
            for (int i = 0; i < input.Length; i++)
            {
                double sum = 0;
                char before = input[i][0];
                char after = input[i][input[i].Length - 1];

                double num = double.Parse(input[i].TrimStart(before).TrimEnd(after));
                int postionInApphabet = 0;
                if (before >= 65 && before <= 90)
                {
                    // uppercase
                    postionInApphabet = before - 64;
                    sum = num / postionInApphabet;
                }
                else
                {
                    // lowercase
                    postionInApphabet = before - 96;
                    sum = num * postionInApphabet;
                }

                if (after >= 65 && after <= 90)
                {
                    // uppercase
                    postionInApphabet = after - 64;
                    sum -= postionInApphabet;
                }
                else
                {
                    // lowercase
                    postionInApphabet = after - 96;
                    sum += postionInApphabet;
                }

                sums.Add(sum);
                sum = 0;
            }
            double total = sums.Sum();
            Console.WriteLine($"{total:f2}");
        }
    }
}
