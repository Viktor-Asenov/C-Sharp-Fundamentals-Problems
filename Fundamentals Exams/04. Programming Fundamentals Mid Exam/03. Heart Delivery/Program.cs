using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine().Split('@').Select(int.Parse).ToList();

            string command = Console.ReadLine();            
            int currentIndex = 0;

            while (command != "Love!")
            {
                string[] input = command.Split();
                int givenLenghtJump = int.Parse(input[1]);
                currentIndex += givenLenghtJump;

                if (currentIndex > houses.Count - 1)
                {                    
                    currentIndex = 0;               
                }
                if (houses[currentIndex] == 0)
                {
                    Console.WriteLine($"Place {currentIndex} already had Valentine's day.");
                }
                else
                {
                     houses[currentIndex] -= 2;

                     if (houses[currentIndex] == 0)
                     {
                         Console.WriteLine($"Place {currentIndex} has Valentine's day.");
                     }
                }                   
                 
                command = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {currentIndex}.");

            int counterFailed = 0;
            int counterSuccessful = 0;

            for (int i = 0; i < houses.Count; i++)
            {
                if (houses[i] > 0)
                {
                    counterFailed++;
                }
                else
                {
                    counterSuccessful++;
                }
            }

            if (counterSuccessful == houses.Count)
            {
                Console.WriteLine($"Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {counterFailed} places.");
            }
        }
    }
}
