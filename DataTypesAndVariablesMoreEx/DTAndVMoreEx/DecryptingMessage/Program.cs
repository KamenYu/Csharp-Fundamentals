using System;

namespace DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            byte key = byte.Parse(Console.ReadLine());
            byte n = byte.Parse(Console.ReadLine());
            string decrypted = "";

            for (int i = 0; i < n; i++)
            {
                char input = char.Parse(Console.ReadLine());
                int num = (int)input + key;
                char message = (char)num;
                decrypted += message.ToString();
            }
            Console.WriteLine(decrypted);
        }
    }
}