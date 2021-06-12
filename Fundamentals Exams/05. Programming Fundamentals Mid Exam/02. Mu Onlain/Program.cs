using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Mu_Onlain
{
    class Program
    {
        static void Main()
        {
            List<string> rooms = Console.ReadLine().Split('|').ToList();

            int initialHealth = 100;
            int bitcoins = 0;
            int bestRoom = 0;

            for (int i = 0; i < rooms.Count ; i++)
            {
                string[] currentRoom = rooms[i].Split();
                string firstElement = currentRoom[0];
                int secondElement = int.Parse(currentRoom[1]);
                
                if (firstElement == "potion")
                {
                    if (initialHealth < 100)
                    {
                        initialHealth += secondElement;                        

                        if (initialHealth > 100)
                        {                            
                            secondElement = secondElement - (initialHealth - 100);
                            initialHealth = 100;
                            Console.WriteLine($"You healed for {secondElement} hp.");
                        }
                        else if (initialHealth <= 100)
                        {
                            Console.WriteLine($"You healed for {secondElement} hp.");
                        }
                        
                        Console.WriteLine($"Current health: {initialHealth} hp.");
                        bestRoom++;
                    }                    
                }
                else if (firstElement == "chest")
                {
                    Console.WriteLine($"You found {secondElement} bitcoins.");
                    bitcoins += secondElement;
                    bestRoom++;
                }
                else
                {
                    initialHealth -= secondElement;
                    bestRoom++;

                    if (initialHealth > 0)
                    {
                        Console.WriteLine($"You slayed {firstElement}.");
                    }
                    else if (initialHealth <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {firstElement}.");
                        Console.WriteLine($"Best room: {bestRoom}");
                        return;
                    }
                }
            }

            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {initialHealth}");
        }
    }
}
