using System;
using System.Collections.Generic;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine()
                .Split();

            List<Students> students = new List<Students>();

            while (line[0] != "end")
            {
                string firstName = line[0];
                string lastName = line[1];
                int age = int.Parse(line[2]);
                string hometown = line[3];


                Students student = new Students()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    Hometown = hometown
                };

                students.Add(student);

                line = Console.ReadLine().Split();
            }

            string filterHT = Console.ReadLine();

            foreach (var student in students)
            {
                if (filterHT == student.Hometown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
    public class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }
    }
}