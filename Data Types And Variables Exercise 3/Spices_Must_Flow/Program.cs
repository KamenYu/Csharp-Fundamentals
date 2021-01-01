using System;

namespace Spices_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            uint startinYeild = uint.Parse(Console.ReadLine());
            uint minedSpice = 0;
            uint total = 0;
            byte countDays = 0;

            while (startinYeild >= 100)
            {
                minedSpice = startinYeild - 26;
                total += minedSpice;
                startinYeild -= 10;
                countDays++;
            }
            if(total >= 26)
            {
                total -= 26;
            }            
            Console.WriteLine(countDays);
            Console.WriteLine(total);
        }
    }
}
