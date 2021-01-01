using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read two arrays and print on the console whether they are identical or not.
            //Arrays are identical if their elements are equal.
            //If the arrays are identical find the sum of the first one and
            //print on the console following message: "Arrays are identical. Sum: {sum}",
            //otherwise find the first index where the arrays differ and
            //print on the console following message: "Arrays are not identical. Found difference at {index} index".

            int[] arr1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] arr2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
                       
            for (int i = 0; i < arr1.Length; i++)
            {
                if(arr1[i] != arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
 
            }          
            int sum = arr1.Sum();
            Console.WriteLine($"Arrays are identical. Sum: {sum}");           
        }
    }
}
