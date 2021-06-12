using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            int numberOfMoves = 0;

            while (true)
            {
                string commandOrIndexes = Console.ReadLine();

                if (commandOrIndexes == "end")
                {
                    break;
                }

                int[] indexes = commandOrIndexes
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int firstIndex = indexes[0];
                int secondIndex = indexes[1];
                numberOfMoves++;

                if (!(input.Count == 0 || firstIndex < 0 || secondIndex < 0)
                    && firstIndex < input.Count && secondIndex < input.Count)
                {
                    if (input[firstIndex] == input[secondIndex])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {input[firstIndex]}!");

                        int greaterIndex = Math.Max(firstIndex, secondIndex);
                        int smallerIndex = Math.Min(firstIndex, secondIndex);
                        input.RemoveAt(greaterIndex);
                        input.RemoveAt(smallerIndex);

                        if (input.Count == 0 || input.Count == 1)
                        {
                            Console.WriteLine($"You have won in {numberOfMoves} turns!");
                            return;
                        }
                    }
                    else if (input[firstIndex] != input[secondIndex])
                    {
                        Console.WriteLine("Try again!");
                    }  
                }                
                else
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    int middleIndex = input.Count / 2;
                    input.Insert(middleIndex, $"-{numberOfMoves}a");
                    input.Insert(middleIndex, $"-{numberOfMoves}a");
                }
            }

            if (input.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", input));
            }
        }
    }
}
