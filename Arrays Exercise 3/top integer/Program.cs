using System;
using System.Linq;

namespace top_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            //A top integer is an integer which is bigger than all the elements to its right. 
            int[] arr = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)      //(e => int.Parse(e))   e as an element
                .ToArray();
            string result = "";
            for (int i = 0; i < arr.Length; i++)
            {
                int current = arr[i];     // take the first and any subsequent element
                bool isTopInteger = true;    // assume all are true

                for (int index = i+1; index < arr.Length; index++)     
                {
                    if (current <= arr[index])     // check if the first is <= to the next one
                    {
                        isTopInteger = false;
                        break;
                    }                   
                }
                if (isTopInteger)
                {
                    result += current + " ";
                }
            }
            Console.WriteLine(result);
        }
    }
}
