using System;

namespace sortNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());

            int big = Math.Max(two, Math.Max(one, three));
            int low = Math.Min(one, Math.Min(two, three));
            
            int mid = (one + two + three) - low - big;           

            Console.WriteLine(big);
            Console.WriteLine(mid);
            Console.WriteLine(low);
        }
    }
}
