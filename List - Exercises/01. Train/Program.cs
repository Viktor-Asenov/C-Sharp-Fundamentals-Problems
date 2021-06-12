using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main()
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacityEachWagon = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int currentNum = 0;

            while (input != "end")
            {
                string[] currentCommand = input.Split();

                if (currentCommand[0] == "Add")
                {
                    Add(wagons, currentNum, currentCommand);
                }
                else
                {
                    AddPassengers(wagons, currentNum, currentCommand, capacityEachWagon);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }

        static List<int> Add (List<int> wagons, int currentNum, string[] currentCommand)
        {
            currentNum = int.Parse(currentCommand[1]);

            wagons.Add(currentNum);

            return wagons;
        }

        static List<int> AddPassengers (List<int> wagons, int currentNum, string[] currentCommand, int capacityEachWagon)
        {
            currentNum = int.Parse(currentCommand[0]);

            for (int i = 0; i < wagons.Count; i++)
            {
                if (wagons[i] + currentNum <= capacityEachWagon)
                {
                    wagons[i] += currentNum;
                    break;
                }
            }

            return wagons;
        }
    }
}
