using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            List<Truck> trucks = new List<Truck>();

            string command = Console.ReadLine();

            double sumCarsHorsepower = 0;
            double sumTrucksHorsepower = 0;

            while (command != "End")
            {
                string[] currentData = command.Split();

                string typeVehicle = currentData[0];
                string model = currentData[1];
                string color = currentData[2];
                int horsePower = int.Parse(currentData[3]);

                if (typeVehicle == "car")
                {
                    var car = new Car
                    {
                        Type = typeVehicle.First().ToString().ToUpper() + typeVehicle.Substring(1),
                        Model = model,
                        Color = color,
                        HorsePower = horsePower
                    };

                    cars.Add(car);
                    sumCarsHorsepower += car.HorsePower;
                }
                else
                {
                    var truck = new Truck
                    {
                        Type = typeVehicle.First().ToString().ToUpper() + typeVehicle.Substring(1),
                        Model = model,
                        Color = color,
                        HorsePower = horsePower
                    };

                    trucks.Add(truck);
                    sumTrucksHorsepower += truck.HorsePower;
                }

                command = Console.ReadLine();
            }

            string newCommand = Console.ReadLine();

            while (newCommand != "Close the Catalogue")
            {
                string input = newCommand;

                foreach (var car in cars)
                {
                    if (input == car.Model)
                    {
                        Console.WriteLine($"Type: {car.Type}");
                        Console.WriteLine($"Model: {car.Model}");
                        Console.WriteLine($"Color: {car.Color}");
                        Console.WriteLine($"Horsepower: {car.HorsePower}");
                    }
                }

                foreach (var truck in trucks)
                {
                    if (input == truck.Model)
                    {
                        Console.WriteLine($"Type: {truck.Type}");
                        Console.WriteLine($"Model: {truck.Model}");
                        Console.WriteLine($"Color: {truck.Color}");
                        Console.WriteLine($"Horsepower: {truck.HorsePower}");
                    }
                }

                newCommand = Console.ReadLine();
            }

            if (cars.Count > 0)
            {
                double carsAverageHorsePower = sumCarsHorsepower / cars.Count;
                Console.WriteLine($"Cars have average horsepower of: {carsAverageHorsePower:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (trucks.Count > 0)
            {
                double trucksAverageHorsePower = sumTrucksHorsepower / trucks.Count;
                Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHorsePower:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        } 
    }

    class VehicleCatalogue
    {
        List<Car> cars = new List<Car>();
        List<Truck> trucks = new List<Truck>();
    }   

    class Car
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }

    class Truck
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }
}
