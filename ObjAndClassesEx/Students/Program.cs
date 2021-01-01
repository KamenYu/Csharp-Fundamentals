using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<StudentInfo> studentRoster = new List<StudentInfo>();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();
                StudentInfo currentStudent = new StudentInfo(info[0], info[1], double.Parse(info[2]));
                studentRoster.Add(currentStudent);
            }
            Console.WriteLine(String.Join(Environment.NewLine, studentRoster.OrderByDescending(x => x.Grade)));
        }

        public class StudentInfo
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }

            public StudentInfo(string firstName, string lastName, double grade)
            {
                FirstName = firstName;
                LastName = lastName;
                Grade = grade;
            }

            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade:f2}";
            }
        }
    }
}
