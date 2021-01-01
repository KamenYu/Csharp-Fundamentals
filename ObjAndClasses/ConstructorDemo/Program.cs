using System;

namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dog sharo = new Dog("Sharo", 6);
            //sharo.PrintDog();
            //Dog mecho = new Dog("Mecho", 3);
            //mecho.PrintDog();

            Human homoSapiens = new Human
                (Console.ReadLine(), Console.ReadLine());
            Console.WriteLine(homoSapiens.FullName);
        }
    }

    class Dog
    {
        public Dog(string name, int age) // can accept parameters
        {
            this.Name = name;
            this.Age = age;
        } // setting the innitial data of the class

        public Dog()   // we can have constructor overloading
        {
            
        }

        public Dog(string name)
        {
            this.Name = name;    
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public void PrintDog()
        {
            Console.WriteLine($"Name = {Name} \nAge = {Age}");
        }
    }

    class Human
    {
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }


        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
