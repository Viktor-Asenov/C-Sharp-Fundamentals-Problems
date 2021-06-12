using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var heroes = new Dictionary<string, Hero>();

            for (int i = 0; i < n; i++)
            {
                string[] currentHero = Console.ReadLine().Split();

                string heroName = currentHero[0];
                int hitPoints = int.Parse(currentHero[1]);
                int manaPoints = int.Parse(currentHero[2]);

                if (!heroes.ContainsKey(heroName))
                {
                    var hero = new Hero
                    {
                        Name = heroName,
                        HitPoints = hitPoints,
                        ManaPoints = manaPoints
                    };

                    heroes[heroName] = hero;
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] currentCommand = command.Split(" - ");

                string action = currentCommand[0];
                string heroName = currentCommand[1];

                if (action == "CastSpell")
                {                    
                    int manaPointsNeeded = int.Parse(currentCommand[2]);
                    string spellName = currentCommand[3];

                    if (heroes[heroName].ManaPoints >= manaPointsNeeded)
                    {
                        heroes[heroName].ManaPoints -= manaPointsNeeded;

                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName].ManaPoints} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (action == "TakeDamage")
                {
                    int damage = int.Parse(currentCommand[2]);
                    string attacker = currentCommand[3];

                    heroes[heroName].HitPoints -= damage;

                    if (heroes[heroName].HitPoints > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName].HitPoints} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        heroes.Remove(heroName);
                    }
                }
                else if (action == "Recharge")
                {
                    int amountRecharging = int.Parse(currentCommand[2]);                    

                    if (heroes[heroName].ManaPoints + amountRecharging > 200)
                    {
                        amountRecharging = 200 - heroes[heroName].ManaPoints;
                        heroes[heroName].ManaPoints = 200;
                    }
                    else
                    {
                        heroes[heroName].ManaPoints += amountRecharging;
                    }

                    Console.WriteLine($"{heroName} recharged for {amountRecharging} MP!");
                }
                else if (action == "Heal")
                {
                    int amountHealing = int.Parse(currentCommand[2]);                    

                    if (heroes[heroName].HitPoints + amountHealing > 100)
                    {
                        amountHealing = 100 - heroes[heroName].HitPoints;
                        heroes[heroName].HitPoints = 100;
                    }
                    else
                    {
                        heroes[heroName].HitPoints += amountHealing;
                    }

                    Console.WriteLine($"{heroName} healed for {amountHealing} HP!");
                }

                command = Console.ReadLine();
            }

            var sortedHeroes = heroes
                .OrderByDescending(x => x.Value.HitPoints)
                .ThenBy(x => x.Value.Name)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var hero in sortedHeroes)
            {
                Console.WriteLine(hero.Value.Name);
                Console.WriteLine($"  HP: {hero.Value.HitPoints}");
                Console.WriteLine($"  MP: {hero.Value.ManaPoints}");
            }
        }
    }

    class Hero
    {
        public string Name { get; set; }

        public int HitPoints { get; set; }

        public int ManaPoints { get; set; }
    }
}
