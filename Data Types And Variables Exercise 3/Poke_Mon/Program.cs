using System;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            // 80 / 100
            uint n = uint.Parse(Console.ReadLine());                
            uint m = uint.Parse(Console.ReadLine());                 
            byte y = byte.Parse(Console.ReadLine());         
            byte counter = 0;
            uint temp = n;

            while (n >= m)
            {
                if (temp / 2 == n && y != 0 && n != 0)
                {
                    n /= y;
                    continue;
                }
                n -= m;     
                counter++;
            }
            Console.WriteLine(n);
            Console.WriteLine(counter);

        }
    }
}
