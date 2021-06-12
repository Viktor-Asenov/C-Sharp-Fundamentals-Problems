using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < wagons.Length; i++)
            {
                if (wagons[i] < 4)
                {
                    while (wagons[i] < 4)
                    {
                        if (numberOfPeople == 0)
                        {
                            Console.WriteLine("The lift has empty spots!");
                            Console.WriteLine(string.Join(" ", wagons));
                            return;
                        }

                        wagons[i]++;
                        numberOfPeople--;
                    }
                }
            }

            if (numberOfPeople > 0)
            {
                Console.WriteLine($"There isn't enough space! {numberOfPeople} people in a queue!");
                Console.WriteLine(string.Join(" ", wagons));
            }
            else if (numberOfPeople == 0)
            {
                Console.WriteLine(string.Join(" ", wagons));
            }
        }
    }
}
