using System;
using System.Linq;
using System.Collections.Generic;

namespace AnonimousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> code = Console.ReadLine()
                .Split()
                .ToList();

            // merge {startIndex} {endIndex}   you must merge all elements from the startIndex, till the endIndex.
            // divide { index} {partitions}
            string input = Console.ReadLine();

            while (input != "3:1")
            {
                string[] commands = input.Split();
                string command = commands[0];

                if (command == "merge")
                {
                    int start = int.Parse(commands[1]);
                    int end = int.Parse(commands[2]);

                    string concatenated = String.Empty;

                    if (start < 0)
                    {
                        if (end <= code.Count - 1 && end >= 0)
                        {
                            start = 0;
                        }
                    }
                    if (end > code.Count -1)
                    {
                        if (start >= 0 && start <= code.Count -1)
                        {
                            end = code.Count - 1;
                        }
                    }

                    if (start < 0 && end > code.Count -1)
                    {
                        start = 0;
                        end = code.Count - 1;
                    }

                    if ((start >= 0 && start <= code.Count - 1)
                        &&
                        (end <= code.Count - 1 && end >= 0))
                    {
                        for (int i = start; i <= end; i++)
                        {
                            concatenated += code[i];
                        }
                        code.RemoveRange(start, end - start + 1);
                        code.Insert(start, concatenated);
                    }
                }
                else if (command == "divide")
                {
                    int index = int.Parse(commands[1]);
                    int partitions = int.Parse(commands[2]);

                    if (index >= 0 && index <= code.Count - 1)
                    {
                        string word = code[index];
                        List<string> divided = new List<string>();
                        int stringLengthToAdd = word.Length / partitions;

                        int startIndex = 0;
                        for (int i = 0; i < partitions; i++)
                        {
                            if (i == partitions - 1)
                            {
                                divided.Add(word.Substring(startIndex, word.Length - startIndex));
                            }
                            else
                            {
                                divided.Add(word.Substring(startIndex, stringLengthToAdd));
                                startIndex += stringLengthToAdd;
                            }
                        }       
                        code.RemoveAt(index);
                        code.InsertRange(index, divided);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", code));
        }
    }
}
