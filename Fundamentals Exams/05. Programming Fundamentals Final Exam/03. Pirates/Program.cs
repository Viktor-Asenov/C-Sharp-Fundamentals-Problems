using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            var targetedCities = new Dictionary<string, City>();

            string input = Console.ReadLine();            

            while (input != "Sail")
            {
                string[] currentCityData = input.Split("||");

                string cityName = currentCityData[0];
                int population = int.Parse(currentCityData[1]);
                decimal gold = decimal.Parse(currentCityData[2]);

                var city = new City
                {
                    Name = cityName,
                    Population = population,
                    Gold = gold
                };

                if (!targetedCities.ContainsKey(cityName))
                {    
                    targetedCities[cityName] = city;
                }
                else
                {
                    targetedCities[cityName].Population += population;
                    targetedCities[cityName].Gold += gold;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                string[] currentEvent = input.Split("=>");

                string eventType = currentEvent[0];

                if (eventType == "Plunder")
                {
                    string cityForPlundering = currentEvent[1];
                    int peopleForKilling = int.Parse(currentEvent[2]);
                    decimal goldForStealing = decimal.Parse(currentEvent[3]);

                    targetedCities[cityForPlundering].Population -= peopleForKilling;
                    targetedCities[cityForPlundering].Gold -= goldForStealing;

                    if (targetedCities[cityForPlundering].Population == 0 || targetedCities[cityForPlundering].Gold == 0)
                    {
                        Console.WriteLine($"{cityForPlundering} plundered! {goldForStealing} gold stolen, {peopleForKilling} citizens killed.");
                        Console.WriteLine($"{targetedCities[cityForPlundering].Name} has been wiped off the map!");
                        targetedCities.Remove(cityForPlundering);
                    }
                    else
                    {
                        Console.WriteLine($"{cityForPlundering} plundered! {goldForStealing} gold stolen, {peopleForKilling} citizens killed.");
                    }
                }
                else
                {
                    string cityForProspering = currentEvent[1];
                    decimal goldForAdding = decimal.Parse(currentEvent[2]);

                    if (goldForAdding < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                    }
                    else
                    {
                        targetedCities[cityForProspering].Gold += goldForAdding;

                        Console.WriteLine($"{goldForAdding} gold added to the city treasury. {cityForProspering} now has {targetedCities[cityForProspering].Gold} gold.");
                    }
                }


                input = Console.ReadLine();
            }

            if (targetedCities.Count > 0)
            {
                var sorted = targetedCities.OrderByDescending(x => x.Value.Gold).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

                Console.WriteLine($"Ahoy, Captain! There are {sorted.Count} wealthy settlements to go to:");

                foreach (var city in sorted)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value.Population} citizens, Gold: {city.Value.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }

    class City
    {
        public string Name { get; set; }

        public int Population { get; set; }

        public decimal Gold { get; set; }
    }
}
