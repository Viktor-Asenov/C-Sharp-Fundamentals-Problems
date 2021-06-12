using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    public class Plant
    {
        public Plant (string name, double rarity)
        {
            this.Name = name;
            this.Rarity = rarity;
            this.Rating = new List<double>();
        }
        public string Name { get; private set; }

        public double Rarity { get; set; }        

        public List<double> Rating { get; set; }

        public double AverageRating
        {
            get
            {
                if (Rating.Count == 0)
                {
                    return 0.00;
                }
                else if (Rating.Count == 1)
                {
                    return Rating[0];
                }
                else
                {
                    return Rating.Sum() / Rating.Count;
                }
            }

            set { }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var plants = new Dictionary<string, Plant>();

            for (int i = 0; i < n; i++)
            {
                string[] plantData = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string plantName = plantData[0];
                double plantRarity = double.Parse(plantData[1]);

                if (!plants.ContainsKey(plantName))
                {
                    plants[plantName] = new Plant(plantName, plantRarity);                    
                }

                else
                {
                    plants[plantName].Rarity += plantRarity;
                }                
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Exhibition")
                {
                    break;
                }

                string[] commandData = command.Split(new[] {':', ' ','-' }, StringSplitOptions.RemoveEmptyEntries);
                string plant = commandData[1];

                if (!plants.ContainsKey(plant))
                {
                    Console.WriteLine("error");                    
                    continue;
                }

                if (commandData[0] == "Rate")
                { 
                    double plantRating = double.Parse(commandData[2]);

                    plants[plant].Rating.Add(plantRating);
                }

                else if (commandData[0] == "Update")
                {
                    double newRarity = double.Parse(commandData[2]);

                    plants[plant].Rarity = newRarity;
                }

                else if (commandData[0] == "Reset")
                {
                    plants[plant].Rating.Clear();                    
                }

                else
                {
                    Console.WriteLine("error");
                }
            }

            var sorted = plants
                .OrderByDescending(p => p.Value.Rarity)
                .ThenByDescending(p => p.Value.AverageRating)
                .ToDictionary(p => p.Key, p => p.Value);

            Console.WriteLine("Plants for the exhibition:");

            foreach (var plant in sorted)
            {
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Rarity}; Rating: {plant.Value.AverageRating:f2}");
            }
        }
    }
}
