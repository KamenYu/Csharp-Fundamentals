using System;
namespace back_in_30_minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
           
            int sumMin = hours * 60 + minutes + 30;
            int hoursAfter30 = sumMin / 60;
            int minAfter30 = sumMin % 60;

            if (hoursAfter30 == 24)
            {
                hoursAfter30 = 0;
                if (minAfter30 <= 9)
                {
                    Console.WriteLine($"{hoursAfter30}:{minAfter30:d2}");
                }
                else
                {
                    Console.WriteLine($"{hoursAfter30}:{minAfter30}");
                }
            }
            else
            {
                Console.WriteLine($"{hoursAfter30}:{minAfter30:d2}");
            }
        }
    }
}
