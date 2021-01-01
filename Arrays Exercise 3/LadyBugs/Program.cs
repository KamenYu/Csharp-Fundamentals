using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            // On the next lines, until you get the "end" command you will receive commands in the format:
            //"{ladybug index} {direction} {fly length}"

            int size = int.Parse(Console.ReadLine());    //3

            int[] indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();                 // 0 1

            int[] field = new int[size];    // 0 0 0
            
            for (int i = 0; i < indexes.Length; i++)
            {
                int currentIndex = indexes[i];

                if (currentIndex >= 0 && currentIndex < size)
                {
                    field[currentIndex] = 1;
                }
            }
            string command = String.Empty;


            while ((command = Console.ReadLine()) != "end")
            {

                string[] elements = command.Split();
                int indexLB = int.Parse(elements[0]);
                string direction = elements[1];
                int length = int.Parse(elements[2]);

                if(indexLB < 0 || indexLB > field.Length - 1 || field[indexLB] == 0) // if index is out of range OR the space is empty
                {
                    continue;
                }

                field[indexLB] = 0;

                if (direction == "right")
                {
                    int landIndex = indexLB + length;

                    if(landIndex > field.Length -1)
                    {
                        continue;
                    }

                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex += length;
                            if (landIndex > field.Length -1)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex >= 0 && landIndex <= field.Length - 1)
                    {
                        field[landIndex] = 1;
                    }
                }
                else if (direction == "left")
                {
                    int landIndex = indexLB - length;

                    if (landIndex < 0)
                    {
                        continue;
                    }
                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex -= length;
                            if (landIndex  < 0)
                            {
                                break;
                            }
                        }
                    }
                    if(landIndex >= 0 && landIndex <= field.Length - 1)
                    {
                        field[landIndex] = 1;
                    }
                }
            }
            Console.WriteLine(String.Join(' ', field)) ;
        }
    }
}
