using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;

namespace SantasSecretHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            string encryptedM = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            List<string> goodChildren = new List<string>();

            while (encryptedM != "end")
            {
                for (int j = 0; j < encryptedM.Length; j++)
                {
                    sb.Append((char)(encryptedM[j] - n));
                }
                encryptedM = sb.ToString();

                // [^@\-!:>\s]*?@([A-Za-z]+)[^@\-!:>\s]*?!(G|N)![^@\-!:>\s]*

                MatchCollection matches = Regex.Matches(encryptedM, @"[^@\-!:>\s]*?@([A-Za-z]+)[^@\-!:>\s]*?!(G|N)![^@\-!:>\s]*");
                foreach (Match item in matches)
                {
                    if (item.Groups[2].Value == "G")
                    {
                        goodChildren.Add(item.Groups[1].Value);
                    }
                }
                encryptedM = Console.ReadLine();
                sb = sb.Clear();
            }
            Console.WriteLine(String.Join(Environment.NewLine, goodChildren));                                    
        }
    }
}
