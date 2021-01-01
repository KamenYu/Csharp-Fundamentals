using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string toEncrypt = Console.ReadLine();
            StringBuilder encrypted = new StringBuilder();

            for (int i = 0; i < toEncrypt.Length; i++)
            {
                encrypted.Append((char)(toEncrypt[i] + 3));
            }
            Console.WriteLine(encrypted);
        }
    }
}
