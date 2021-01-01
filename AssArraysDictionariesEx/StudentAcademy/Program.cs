using System;
using System.Linq;
using System.Collections.Generic;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentGrades.ContainsKey(studentName))
                {
                    studentGrades.Add(studentName, new List<double>());
                }
                studentGrades[studentName].Add(grade);
            }

            Dictionary<string, double> average = new Dictionary<string, double>();
            foreach (var item in studentGrades)
            {
                average.Add(item.Key, item.Value.Average());
            }

            foreach (var item in average.Where(x => x.Value >= 4.5)
                .OrderByDescending(student => student.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
