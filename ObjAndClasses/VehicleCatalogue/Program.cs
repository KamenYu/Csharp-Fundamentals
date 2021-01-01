using System;
using System.Linq;
using System.Collections.Generic;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main()
        {
            // {type}/{brand}/{model}/{horse power / weight}

            string[] input = Console.ReadLine()
                .Split('/');

            Catalogue vehicleCatalogue = new Catalogue();

            while (input[0] != "end")
            {
                if (input[0] == "Car")
                {
                    vehicleCatalogue.CarCat.Add(new Car
                    {
                        Brand = input[1],
                        Model = input[2],
                        HorsePower = int.Parse(input[3])
                    }) ;
                }
                else
                {
                    vehicleCatalogue.TruckCat.Add(new Truck
                    {
                        Brand = input[1],
                        Model = input[2],
                        Weight = int.Parse(input[3])
                    });
                }

                input = Console.ReadLine().Split('/');
            }

            if (vehicleCatalogue.CarCat.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car item in vehicleCatalogue.CarCat.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.HorsePower}hp");
                }
            }
            if (vehicleCatalogue.TruckCat.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck item in vehicleCatalogue.TruckCat.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}kg");
                }
            }
        }

        public class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int    Weight { get; set; }
        }

        public class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int    HorsePower { get; set; }
        }

        public class Catalogue
        {
            public List<Truck> TruckCat { get; set; }
            public List<Car> CarCat { get; set; }

            public Catalogue()
            {
                TruckCat = new List<Truck>();
                CarCat = new List<Car>();
            }
        }
    }
}
