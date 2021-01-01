using System;
using System.Text;

namespace again
{
    class Program
    {
        static void Main(string[] args)
        {
            // mutiply big number without BigInteger

            string numbers = Console.ReadLine().TrimStart('0');
            byte n = byte.Parse(Console.ReadLine());  // 0 - 9
            int remainder = 0;
            int result = 0;

            if (n == 0)
            {
                Console.WriteLine(0);
                return;
            }

            StringBuilder sb = new StringBuilder();

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                result = int.Parse(numbers[i].ToString()) * n + remainder;
                remainder = 0;

                if (result > 9) // 15
                {
                    remainder = result / 10;
                    result %= 10;
                }
                sb.Append(result);
            }

            if (remainder > 0)
            {
                sb.Append(remainder);
            }

            StringBuilder reversed = new StringBuilder(sb.Length);
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                reversed.Append(sb[i]);
            }
            Console.WriteLine(reversed);
        }
    }
}
