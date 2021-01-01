using System;
using System.Linq;
using System.Collections.Generic;

namespace OrtderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<PersonInfo> roster = new List<PersonInfo>();

            while (input != "End")
            {
                string[] personsInfo = input.Split();
                string name = personsInfo[0];
                string ID = personsInfo[1];
                int age = int.Parse(personsInfo[2]);

                PersonInfo currentPerson = new PersonInfo(name, ID, age);
                roster.Add(currentPerson);
                input = Console.ReadLine();
            }

            List<PersonInfo> rosterTwo = roster.OrderBy(x => x.Age).ToList(); // orderBy returns a new collection
            Console.WriteLine(string.Join(Environment.NewLine, rosterTwo));
        }
    }

    class PersonInfo
    {
        public PersonInfo(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
