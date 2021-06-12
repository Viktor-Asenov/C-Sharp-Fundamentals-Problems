using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            var targets = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            int targetIndex = 0;
            int powerShot = 0;
            int value = 0;
            int radius = 0;

            while (command != "End")
            {
                string[] currentCommand = command.Split();

                string action = currentCommand[0];

                switch (action)
                {
                    case "Shoot": 
                        Shoot(targets, targetIndex, powerShot, currentCommand);
                        break;
                    case "Add":
                        Add(targets, targetIndex, value, currentCommand);
                        break;
                    case "Strike":
                        Strike(targets, targetIndex, radius, currentCommand);
                        break;
                }


                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join('|', targets));
        }

        static List<int> Shoot(List<int> targets, int targetIndex, int powerShot, string[] currentCommand)
        {
            targetIndex = int.Parse(currentCommand[1]);
            powerShot = int.Parse(currentCommand[2]);

            if (targetIndex > targets.Count - 1 || targetIndex < 0 || powerShot <= 0)
            {

            }
            else if (targets[targetIndex] > 0)
            {
                targets[targetIndex] -= powerShot;

                if (targets[targetIndex] <= 0)
                {
                    targets.RemoveAt(targetIndex);
                }
            }

            return targets;
        }

        static List<int> Add (List<int> targets, int targetIndex, int value, string[] currentCommand)
        {
            targetIndex = int.Parse(currentCommand[1]);
            value = int.Parse(currentCommand[2]);

            if (targetIndex > targets.Count - 1 || targetIndex < 0 || value <= 0)
            {
                Console.WriteLine("Invalid placement!");
            }
            else
            {
                targets.Insert(targetIndex, value);
            }

            return targets;
        }

        static List<int> Strike (List<int> targets, int targetIndex, int radius, string[] currentCommand)
        {
            targetIndex = int.Parse(currentCommand[1]);
            radius = int.Parse(currentCommand[2]);

            int startRemoving = targetIndex - radius;
            int range = startRemoving + targetIndex;

            if (startRemoving <= 0 || range > targets.Count - 1 || radius <= 0 || targetIndex <= 0 
                || targetIndex > targets.Count - 1 || radius > targets.Count - 1 || range <= 0)
            {
                Console.WriteLine("Strike missed!");
            }
            else
            {                  
                targets.RemoveRange(startRemoving, range);                   
                             
            }            

            return targets;
        }
    }
}
