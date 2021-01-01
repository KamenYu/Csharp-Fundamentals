using System;
using System.Text;

namespace MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] morse = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            StringBuilder decrypted = new StringBuilder();

            for (int i = 0; i < morse.Length; i++)
            {
                switch (morse[i])
                {
                    case ".-":
                        decrypted.Append("A");
                        break;
                    case "-...":
                        decrypted.Append("B");
                        break;
                    case "-.-.":
                        decrypted.Append("C");
                        break;
                    case "-..":
                        decrypted.Append("D");
                        break;
                    case ".":
                        decrypted.Append("E");
                        break;
                    case "..-.":
                        decrypted.Append("F");
                        break;
                    case "--.":
                        decrypted.Append("G");
                        break;
                    case "....":
                        decrypted.Append("H");
                        break;
                    case "..":
                        decrypted.Append("I");
                        break;
                    case ".---":
                        decrypted.Append("J");
                        break;
                    case "-.-":
                        decrypted.Append("K");
                        break;
                    case ".-..":
                        decrypted.Append("L");
                        break;
                    case "--":
                        decrypted.Append("M");
                        break;
                    case "-.":
                        decrypted.Append("N");
                        break;
                    case "---":
                        decrypted.Append("O");
                        break;
                    case ".--.":
                        decrypted.Append("P");
                        break;
                    case "--.-":
                        decrypted.Append("Q");
                        break;
                    case ".-.":
                        decrypted.Append("R");
                        break;
                    case "...":
                        decrypted.Append("S");
                        break;
                    case "-":
                        decrypted.Append("T");
                        break;
                    case "..-":
                        decrypted.Append("U");
                        break;
                    case "...-":
                        decrypted.Append("V");
                        break;
                    case ".--":
                        decrypted.Append("W");
                        break;
                    case "-..-":
                        decrypted.Append("X");
                        break;
                    case "-.--":
                        decrypted.Append("Y");
                        break;
                    case "--..":
                        decrypted.Append("Z");
                        break;
                    case "|":
                        decrypted.Append(" ");
                        break;
                }
            }

            Console.WriteLine(decrypted);
        }
    }
}
