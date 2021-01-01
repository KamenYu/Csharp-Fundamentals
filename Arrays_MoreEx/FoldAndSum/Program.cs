using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int centre = array.Length / 2;
            int sides = centre / 2;
            // 1 3 6 7 3 2 1 9
            int[] arr1 = new int[centre];
            int start = sides;
            int end = array.Length - 1 - sides;
            int j = 0;
            for (int i = start; i <= end; i++)
            {                
                arr1[j] = array[i];
                j++;
            }

            int[] arr3 = new int[sides];

            for (int i = 0; i < sides; i++)
            {
                arr3[i] = array[i];
            }

            int[] arr4 = new int[sides];
            j = 0;
            for (int i = end + 1; i < array.Length; i++)
            {
                arr4[j] = array[i];
                j++;
            }
            Array.Reverse(arr3);
            Array.Reverse(arr4);

            int[] arr2 = new int[centre];
            for (int i = 0; i < arr3.Length; i++)
            {
                arr2[i] = arr3[i];
            }

            j = arr3.Length;
            int k = 0;
            for (int i = j; i < arr2.Length; i++)
            {
                arr2[j] = arr4[k];
                j++;
                k++;
            }

            int[] folded = new int[centre];
            for (int i = 0; i < arr1.Length; i++)
            {
                folded[i] = arr1[i] + arr2[i];
            }
            Console.WriteLine(string.Join(' ', folded));
        }
    }
}
