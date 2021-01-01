using System;

namespace messages
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  2 = a, 22 = b, 222 = c,
             *  3 = d, 33 = e, 333 = f,
             *  4 = g, 44 = h, 444 = i,
             *  5 = j, 55 = k, 555 = l,
             *  6 = m, 66 = n, 666 = o,
             *  7 = p, 77 = q, 777 = r, 7777 = s;
             *  8 = t, 88 = u, 888 = v,
             *  9 = w, 99 = x, 999 = y, 999 = z
             *  0 = space     */

            int n = int.Parse(Console.ReadLine());
            string numToLetter = "";
            int digits = 0;
            int main = 0;
            int offset = 0;
            int index = 0;
            int letter = 0;
            string message = "";

            for (int i = 0; i < n; i++)
            {
                numToLetter = Console.ReadLine();
                digits = numToLetter.Length;

                main = int.Parse(numToLetter) % 10;

                if (main == 8 || main == 9)
                {
                    offset = 1 + (main - 2) * 3; 
                }
                else
                {
                    offset = (main - 2) * 3;
                }

                index = (offset + digits) - 1;
                letter = 97 + index;
                char realLetter = (char)letter;
                if (main == 0)
                {
                    message += " ";                  
                }
                else
                {
                    message += realLetter;               
                }
            }
            Console.WriteLine(message);
        }
    }
}
