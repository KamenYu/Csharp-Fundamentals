using System;

namespace array_rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOne = Console.
                ReadLine()
                .Split();
            int rotations = int.Parse(Console.ReadLine());
            // 1 2 3 4 -> 2 3 4 1 for one rotation
            // 2 3 4 1 -> 3 4 1 2 for two rotations ...
            rotations %= arrayOne.Length;  // to optimize the process

            for (int r = 0; r < rotations; r++)
            {
                string temp = arrayOne[0];  // keep the first element
                for (int i = 0; i < arrayOne.Length - 1; i++)  // rotate the other elements second becoming first, third -> second..
                {
                    arrayOne[i] = arrayOne[i + 1];
                }
                arrayOne[arrayOne.Length - 1] = temp;         // change the last value to the variable
            }
            Console.WriteLine(string.Join(" ", arrayOne));   // print
        }
    }
}
