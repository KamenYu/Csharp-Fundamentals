using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class Program
    {
        public class Engine
        {
            public int Speed { get; set; }
            public int Power { get; set; }
            public Engine(int speed, int power)
            {
                Speed = speed;
                Power = power;
            }
        }

        public class Cargo
        {
            public int Weight { get; set; }
            public string Type { get; set; }
            public Cargo(int weight, string type)
            {
                Weight = weight;
                Type = type;
            }
        }

        public class Car
        {
            public string Model { get; set; }
            public Engine CurrentE { get; set; }
            public Cargo CurrentC { get; set; }

            public Car(string[] info)
            {
                Model = info[0];
                CurrentE = new Engine(int.Parse(info[1]), int.Parse(info[2]));
                CurrentC = new Cargo(int.Parse(info[3]), info[4]);
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                Car car = new Car(carInfo);
                cars.Add(car);

            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var item in cars.Where(c => c.CurrentC.Type == "fragile" && c.CurrentC.Weight < 1000))
                {
                    Console.WriteLine(item.Model);
                }
            }
            else
            {
                foreach (var item in cars.Where(c => c.CurrentC.Type == "flamable" && c.CurrentE.Power > 250))
                {
                    Console.WriteLine(item.Model);
                }
            }
        }
    }
}
