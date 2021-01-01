using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string decrypted = string.Empty;
            StringBuilder sb = new StringBuilder();
            List<string> list = new List<string>();
            while ((decrypted = Console.ReadLine()) != "find")
            {
                for (int i = 0; i < decrypted.Length; i+=0)
                {
                    for (int j = 0; j < key.Length; j++)
                    {                       
                        if (i > decrypted.Length - 1)
                        {
                            break;
                        }
                        else
                        {
                            char toSB = (char)(decrypted[i] - key[j]);
                            sb.Append(toSB.ToString());
                        }                        
                        i++;
                    }
                }

                Match treasure = Regex.Match(sb.ToString(), @"&([A-Za-z]*)&"); // no idea why *
                Match coordinates = Regex.Match(sb.ToString(), @"<(.*)>");     // it can be anything???

                if (treasure.Success && coordinates.Success)
                {
                    Console.WriteLine($"Found {treasure.Groups[1].Value} at {coordinates.Groups[1].Value}");
                }
                sb.Clear();
            }
        }
    }
}
