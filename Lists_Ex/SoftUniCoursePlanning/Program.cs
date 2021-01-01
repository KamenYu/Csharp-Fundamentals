using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split(", ")
                .ToList();

            string[] input = Console.ReadLine()
                           .Split(':')
                           .ToArray();

            while (input[0] != "course start")
            {
                switch (input[0])
                {
                    case "Add":                           // Add:{lessonTitle}

                        if (!list.Contains(input[1]))
                        {
                            list.Add(input[1]);
                        }
                    
                        break;

                    case "Insert":                                 // Insert:{lessonTitle}:{index}
                                                                    // check INSERT the indexes
                        int index = int.Parse(input[2]);

                        if (!list.Contains(input[1]))
                        {
                            list.Insert(index, input[1]);
                        }
                        
                        break;
                    
                    case "Remove":              // Remove: {lessonTitle}

                        if (list.Contains(input[1]))
                        {
                            int indexToRemove = list.IndexOf(input[1]);
                            list.RemoveAt(indexToRemove);
                            if (indexToRemove == list.Count)
                            {
                                input = Console.ReadLine().Split(':').ToArray();
                                continue;
                            }
                            else if (list[indexToRemove] == $"{input[1]}-Exercise")
                            {
                                list.RemoveAt(indexToRemove);
                            }
                        }
                        break;

                    case "Swap":                        //Swap:{lessonTitle}:{lessonTitle}

                        string lesson1 = input[1];
                        string lesson2 = input[2];

                        {
                            int indexOfLesson1 = list.IndexOf(lesson1);
                            int indexOfLesson2 = list.IndexOf(lesson2);

                            if (list.Contains(input[1]) && list.Contains(input[2]))
                            {
                                list[indexOfLesson1] = lesson2;
                                list[indexOfLesson2] = lesson1;
                            }

                            if (list.Contains($"{input[1]}-Exercise"))
                            {
                                // Lists, Lists-E, Methods, OAC
                                // OAC, Methods, Lists, Lists-E

                                string lesson1Ex = list[indexOfLesson1 + 1];
                                list.RemoveAt(indexOfLesson1 + 1);

                                if (indexOfLesson2 == list.Count)
                                {
                                    list.Add(lesson1Ex);
                                }
                                else
                                {
                                    list.Insert(indexOfLesson2, lesson1Ex);
                                }                               
                            }

                            if (list.Contains($"{input[2]}-Exercise"))
                            {
                                string lesson2Ex = list[indexOfLesson2 + 1];
                                list.RemoveAt(indexOfLesson2 + 1);
                                list.Insert(indexOfLesson1 + 1, lesson2Ex);
                            }     
                        }
     
                        break;

                    case "Exercise":                              // Exercise:{lessonTitle}
                                                                  // {lessonTitle}-Exercise

                        if (list.Contains(input[1]))
                        {
                            if (!list.Contains($"{input[1]}-Exercise"))
                            {
                                int indexForEx = list.IndexOf(input[1]);
                                if (indexForEx == list.Count - 1)
                                {
                                    list.Add($"{input[1]}-Exercise");
                                }
                                else
                                {
                                    int indexToInsert = list.IndexOf(input[1]) + 1;
                                    list.Insert(indexToInsert, $"{input[1]}-Exercise");
                                }                               
                            }
                        }
                        else
                        {
                            list.Add(input[1]);
                            list.Add($"{input[1]}-Exercise");
                        }

                        break;
                }
                input = Console.ReadLine().Split(':').ToArray();
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{list[i]}");
            }
        }
    }
}
