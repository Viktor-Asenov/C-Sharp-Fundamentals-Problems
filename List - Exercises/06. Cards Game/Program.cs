using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondDeck = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < firstDeck.Count; i++)
            {
                for (int j = 0; j < secondDeck.Count; j++)
                {
                    if (firstDeck[i] > secondDeck[j])
                    {                        
                        firstDeck.Add(firstDeck[i]);
                        firstDeck.RemoveAt(i);
                        firstDeck.Add(secondDeck[j]);
                        secondDeck.Remove(secondDeck[j]);
                        j--;
                    }
                    else if (firstDeck[i] < secondDeck[j])
                    {
                        secondDeck.Add(secondDeck[j]);
                        secondDeck.RemoveAt(j);
                        secondDeck.Add(firstDeck[i]);
                        firstDeck.Remove(firstDeck[i]);
                        j--;
                    }
                    else
                    {
                        firstDeck.RemoveAt(i);
                        secondDeck.RemoveAt(j);
                        j--;
                    }
                    
                    if (firstDeck.Count == 0)
                    {
                        Console.WriteLine($"Second player wins! Sum: {secondDeck.Sum()}");
                        return;
                    }
                }
                if (secondDeck.Count == 0)
                {
                    Console.WriteLine($"First player wins! Sum: {firstDeck.Sum()}");
                    break;
                }               
            }          
        }
    }
}
