using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] input = command.Split('/');

                if (input[0] == "Car")
                {
                    string type = input[0];
                    string brand = input[1];
                    string model = input[2];
                    int horsePower = int.Parse(input[3]);

                    Car car = new Car();

                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = horsePower;

                    cars.Add(car);
                }
                else
                {
                    string type = input[0];
                    string brand = input[1];
                    string model = input[2];
                    int weight = int.Parse(input[3]);

                    Truck truck = new Truck();

                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = weight;

                    trucks.Add(truck);
                }

                command = Console.ReadLine();
            }

            var orderedCars = cars.OrderBy(x => x.Brand).ToList();
            var orderedTrucks = trucks.OrderBy(x => x.Brand).ToList();

            if (orderedTrucks.Count == 0)
            {
                Console.WriteLine("Cars:");

                foreach (var car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }                
            }
            else if (orderedCars.Count == 0)
            {
                Console.WriteLine("Trucks:");

                foreach (var truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
            else
            {
                Console.WriteLine("Cars:");

                foreach (var car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }

                Console.WriteLine("Trucks:");

                foreach (var truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

    class CatalogueVehicle
    {        
        public List<Car> cars { get; set; }
        public List<Truck> trucks { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }
    }

    class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }
    }
}
