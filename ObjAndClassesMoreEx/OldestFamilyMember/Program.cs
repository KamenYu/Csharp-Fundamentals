using System;
using System.Collections.Generic;
using System.Linq;

namespace OldestFamilyMember
{
    class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public class Family
        {
            public List<Person> Members { get; set; } = new List<Person>();

            public void AddMember(Person member)
            {
                Members.Add(member);
            }

            public Person GetOldest()
            {
                return Members.OrderByDescending(x => x.Age).First();
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] famMemberInfo = Console.ReadLine().Split();
                family.AddMember(new Person
                {
                    Name = famMemberInfo[0],
                    Age = int.Parse(famMemberInfo[1])
                });
            }

            Person oldest = family.GetOldest();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}
