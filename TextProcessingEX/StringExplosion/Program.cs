using System;
using System.Text;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            // SANYA RULES !!
            string test = Console.ReadLine();  // abv>1>1>2>2asdasd
            int power = 0;

            StringBuilder sb = new StringBuilder();
                                               // pesho>2sis>1a>2akarate>4hexmaster
            for (int i = 0; i < test.Length; i++)
            {
                if (test[i] == '>')
                {
                    power += int.Parse(test[i + 1].ToString());
                    sb.Append(test[i]);
                }
                else if (power == 0)
                {
                    sb.Append(test[i]);
                }
                else
                {
                    power--;
                }
            }           
            Console.WriteLine(sb);
        }
    }
}
