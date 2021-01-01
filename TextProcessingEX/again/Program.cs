using System;
using System.Text;

namespace again
{
    class Program
    {
        static void Main(string[] args)
        {
            // String Explosion - Kamen

            string mineField = Console.ReadLine();
            byte power = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < mineField.Length; i++)
            {
                if (mineField[i] == '>')
                {
                    power += byte.Parse(mineField[i + 1].ToString());
                    sb.Append(mineField[i]);
                    mineField = mineField.Remove(i + 1, 1);
                    power--;
                }
                else if (power > 0)
                {
                    mineField = mineField.Remove(i, 1);
                    power--;
                }
                else
                {
                    sb.Append(mineField[i]);
                }
            }
            Console.WriteLine(sb);
        }
    }
}
