using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    class Program
    {
        public class Car
        {
            public string Model { get; set; }
            public double FuelAmount { get; set; }
            public double FuelConsumptionPerKm { get; set; }
            public int TraveledDistance { get; set; } = 0; // ??

            public Car(string model, double fuelAmount, double fuelConumptionPerKm)
            {
                Model = model;
                FuelAmount = fuelAmount;
                FuelConsumptionPerKm = fuelConumptionPerKm;
            }

            public void DistanceChecker(int distance)
            {
                if (FuelAmount >= FuelConsumptionPerKm * distance)
                {
                    FuelAmount -= FuelConsumptionPerKm * distance;
                    TraveledDistance += distance;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }

            public override string ToString()
            {
                return $"{Model} {FuelAmount:f2} {TraveledDistance}";
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                Car car = new Car(carInfo[0], double.Parse(carInfo[1]), double.Parse(carInfo[2]));
                cars.Add(car);
            }

            string commands = string.Empty;

            while ((commands = Console.ReadLine()) != "End")
            {
                string[] tokens = commands.Split();
                string model = tokens[1];
                int distance = int.Parse(tokens[2]);
                cars.Find(c => c.Model == model).DistanceChecker(distance);
            }
            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }
    }
}