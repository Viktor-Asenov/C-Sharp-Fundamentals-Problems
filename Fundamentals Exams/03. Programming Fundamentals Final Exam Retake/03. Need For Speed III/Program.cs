using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_For_Speed_III
{
    class Car
    {
        public string Name { get; set; }

        public int Mileage { get; set; }

        public int Fuel { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var cars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                string[] currentCar = Console.ReadLine().Split("|");

                string carName = currentCar[0];
                int mileage = int.Parse(currentCar[1]);
                int fuel = int.Parse(currentCar[2]);

                var car = new Car
                {
                    Name = carName,
                    Mileage = mileage,
                    Fuel = fuel
                };

                cars[carName] = car;
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] currentCommand = command.Split(" : ");

                string carName = currentCommand[1];

                if (currentCommand[0].Contains("Drive"))
                {
                    int distance = int.Parse(currentCommand[2]);
                    int fuel = int.Parse(currentCommand[3]);

                    if (cars[carName].Fuel < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        cars[carName].Mileage += distance;
                        cars[carName].Fuel -= fuel;

                        Console.WriteLine($"{carName} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    }

                    if (cars[carName].Mileage >= 100000)
                    {
                        Console.WriteLine($"Time to sell the {carName}!");

                        cars.Remove(carName);
                    }
                }
                else if (currentCommand[0].Contains("Refuel"))
                {
                    int fuel = int.Parse(currentCommand[2]);                    

                    if (cars[carName].Fuel + fuel > 75)
                    {
                        Console.WriteLine($"{carName} refueled with {75 - cars[carName].Fuel} liters");

                        cars[carName].Fuel = 75;
                    }
                    else
                    {
                        cars[carName].Fuel += fuel;

                        Console.WriteLine($"{carName} refueled with {fuel} liters");
                    }
                }
                else if (currentCommand[0].Contains("Revert"))
                {
                    int kilometers = int.Parse(currentCommand[2]);

                    if (cars[carName].Mileage - kilometers < 10000)
                    {
                        cars[carName].Mileage = 10000;
                    }
                    else
                    {
                        cars[carName].Mileage -= kilometers;
                        Console.WriteLine($"{carName} mileage decreased by {kilometers} kilometers");
                    }
                }

                command = Console.ReadLine();
            }

            var sorted = cars
                .OrderByDescending(x => x.Value.Mileage)
                .ThenBy(x => x.Value.Name)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var car in sorted)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value.Mileage} kms, Fuel in the tank: {car.Value.Fuel} lt.");
            }
        }
    }
}
