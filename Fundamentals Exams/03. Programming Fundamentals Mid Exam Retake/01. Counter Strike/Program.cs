using System;

namespace _01._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingEnergy = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int countWonBattles = 0;

            while (command != "End of battle")
            {
                int distanceToEnemy = int.Parse(command);

                if (distanceToEnemy > startingEnergy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {countWonBattles} won battles and {startingEnergy} energy");
                    return;
                }
                else
                {
                    startingEnergy -= distanceToEnemy;
                    countWonBattles++;

                    if (countWonBattles % 3 == 0)
                    {
                        startingEnergy += countWonBattles;
                    }
                }               


                command = Console.ReadLine();
            }

            Console.WriteLine($"Won battles: {countWonBattles}. Energy left: {startingEnergy}");
        }
    }
}
