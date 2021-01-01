using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // C:\Internal\training-internal\Template.pptx
            string[] input = Console.ReadLine().Split('\\');
            string[] nameAndExtention = input[input.Length -1].Split('.');
            Console.WriteLine($"File name: {nameAndExtention[0]}");
            Console.WriteLine($"File extension: {nameAndExtention[1]}");            
        }
    }
}
