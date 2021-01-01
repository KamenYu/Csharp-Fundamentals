using System;

namespace CharMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string first = input[0];
            string second = input[1];
            Console.WriteLine(CharMultiplier(first, second));
        }

        static int CharMultiplier(string first, string second)
        {
            int sum = 0;
            string longer = "";
            string shorter = "";

            if (first.Length > second.Length)
            {
                longer = first;
                shorter = second;
            }
            else
            {
                longer = second;
                shorter = first;
            }


            for (int i = 0; i < shorter.Length; i++)
            {
                sum += first[i] * second[i];
            }

            for (int i = shorter.Length; i < longer.Length; i++)
            {
                sum += longer[i];
            }

            return sum;
        }
    }
}
