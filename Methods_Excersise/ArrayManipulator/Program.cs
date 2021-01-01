using System;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                
                if (command[0] == "exchange")
                {
                    int index = int.Parse(command[1]);

                    if(index < 0 || index > array.Length -1)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    Exchange(array, index);
                }
                else if (command[0] == "max")
                {
                    if (command[1] == "even")
                    {
                        if (MaxEven(array) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MaxEven(array));
                    }
                    else
                    {
                        if (MaxOdd(array) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MaxOdd(array));
                    }

                }
                else if (command[0] == "min")
                {
                    if (command[1] == "even")
                    {
                        if (MinEven(array) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MinEven(array));
                    }
                    else
                    {
                        if (MinOdd(array) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MinOdd(array));
                    }
                }
                else if (command[0] == "first")
                {
                    int count = int.Parse(command[1]);

                    if (count > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    if (command[2] == "even")
                    {
                        ReturnFirstEven(array, count);
                    }
                    else
                    {
                        ReturnFirstOdd(array, count);
                    }
                }
                else if (command[0] == "last")
                {
                    int count = int.Parse(command[1]);

                    if (count > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    if (command[2] == "even")
                    {
                        ReturnLastEven(array, count);
                    }
                    else
                    {
                        ReturnLastOdd(array, count);
                    }
                }
            }
            Console.WriteLine("[" + String.Join(", ", array) + "]");
        }

        static void Exchange(int[] array, int index)
        {
            // 1 3 5 7 9 , exchange 1 -> first = 5 7 9 , second = 1 3
            int[] first = new int[array.Length - index - 1];
            int[] second = new int[index + 1];
            int firstCounter = 0;
            
            for (int i = index + 1; i < array.Length; i++)
            {
                first[firstCounter] = array[i];
                firstCounter++;
            }

            for (int i = 0; i < index + 1; i++)
            {
                second[i] = array[i];
            }

            for (int i = 0; i < first.Length; i++)
            {
                array[i] = first[i];
            }

            for (int i = 0; i < second.Length; i++)
            {
                array[first.Length + i] = second[i];
            }
        }

        static int MaxEven(int[] array)
        {
            int maxEven = int.MinValue;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (array[i] >= maxEven)
                    {
                        maxEven = array[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        static int MaxOdd(int[] array)
        {
            int maxOdd = int.MinValue;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    if (array[i] >= maxOdd)
                    {
                        maxOdd = array[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        static int MinEven(int[] array)
        {
            int minEven = int.MaxValue;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (array[i] <= minEven)
                    {
                        minEven = array[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        static int MinOdd(int[] array)
        {
            int minOdd = int.MaxValue;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    if (array[i] <= minOdd)
                    {
                        minOdd = array[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        static void ReturnFirstEven (int[] array, int count)
        {
            string elements = string.Empty;
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    elements += array[i] + " ";
                    counter++;
                }
                if (count == counter)
                {
                    break;
                }
            }
            var result = elements.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + String.Join(", ", result) + "]");
            }
        }

        static void ReturnFirstOdd(int[] array, int count)
        {
            string elements = string.Empty;
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    elements += array[i] + " ";
                    counter++;
                }
                if (count == counter)
                {
                    break;
                }
            }
            var result = elements.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + String.Join(", ", result) + "]");
            }
        }

        static void ReturnLastEven(int[] array, int count)
        {
            string numbers = string.Empty;
            int counter = 0;

            for (int i = array.Length - 1; i > -1; i--)
            {
                if (array[i] % 2 == 0)
                {
                    counter++;
                    numbers += array[i] + " ";
                }

                if (count == counter)
                {
                    break;
                }
            }
            var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse();

            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + String.Join(", ", result) + "]");
            }
        }

        static void ReturnLastOdd(int[] array, int count)
        {
            string numbers = string.Empty;
            int counter = 0;

            for (int i = array.Length - 1; i > -1; i--)
            {
                if (array[i] % 2 != 0)
                {
                    counter++;
                    numbers += array[i] + " ";
                }

                if (count == counter)
                {
                    break;
                }
            }
            var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse();

            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + String.Join(", ", result) + "]");
            }
        }
    }
}
