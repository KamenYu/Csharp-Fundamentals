using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            // {typeOfVehicle} {model} {color} {horsepower}
            string input = Console.ReadLine();
            List<VehicleCatalogue> roster = new List<VehicleCatalogue>();
            while (input != "End")
            {
                string[] tokens = input.Split();
                string type = tokens[0];
                string model = tokens[1];
                string colour = tokens[2];
                double horsePower = double.Parse(tokens[3]);

                VehicleCatalogue catalogue = new VehicleCatalogue(type, model, colour, horsePower);
                roster.Add(catalogue);                
                
                input = Console.ReadLine();
            }
            string inputTwo = Console.ReadLine();

            while (inputTwo != "Close the Catalogue")
            {
                string model = inputTwo;

                VehicleCatalogue printCar = roster.First(x => x.Model == model);

                Console.WriteLine(printCar);

                inputTwo = Console.ReadLine();
            }

            List<VehicleCatalogue> onlyCars = roster.Where(x => x.Type == "car").ToList();
            List<VehicleCatalogue> onlyTrucks = roster.Where(x => x.Type == "truck").ToList();

            double sumCarsHp = onlyCars.Sum(x => x.HorsePower);
            double sumTrucksHp = onlyTrucks.Sum(x => x.HorsePower);

            double averageCarHp = 0;       // there is a chance that there are either no cars or no trucks
            double averageTruckHp = 0;     // so division by 0 is invalid

            if (onlyCars.Count > 0) //??
            {
                averageCarHp = sumCarsHp / onlyCars.Count;
            }
            if (onlyTrucks.Count > 0)
            {
                averageTruckHp = sumTrucksHp / onlyTrucks.Count;
            }           

            Console.WriteLine($"Cars have average horsepower of: {averageCarHp:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTruckHp:f2}.");
        }

        class VehicleCatalogue
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Colour { get; set; }
            public double HorsePower { get; set; }  // check

            public VehicleCatalogue(string type, string model, string colour, double horsePower)
            {
                Type = type;
                Model = model;
                Colour = colour;
                HorsePower = horsePower;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"Type: {(Type == "car" ? "Car" : "Truck")}");
                sb.AppendLine($"Model: {Model}");
                sb.AppendLine($"Color: {Colour}");
                sb.AppendLine($"Horsepower: {HorsePower}");

                return sb.ToString().TrimEnd();
            }
        }
    }
}
