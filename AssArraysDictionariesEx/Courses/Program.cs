using System;
using System.Linq;
using System.Collections.Generic;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(" : ");
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (command[0] != "end")
            {
                string currentCourse = command[0];
                string currentStudent = command[1];

                if (courses.ContainsKey(currentCourse) == false)
                {
                    courses.Add(currentCourse, new List<string>());
                }
                courses[currentCourse].Add(currentStudent);
                
                command = Console.ReadLine().Split(" : ");
            }

            foreach (var item in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");

                foreach (var student in item.Value.OrderBy(x =>x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
