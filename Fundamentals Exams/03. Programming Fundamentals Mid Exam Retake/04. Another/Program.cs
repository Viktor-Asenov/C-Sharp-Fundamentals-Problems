using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Another
{
    class Program
    {
        static void Main(string[] args)
        {
            var targets = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] currentCommand = command.Split();

                string action = currentCommand[0];
                int index = int.Parse(currentCommand[1]);

                if (action == "Shoot")
                {
                    int powerShot = int.Parse(currentCommand[2]);

                    if (index >= 0 && index < targets.Count)
                    {
                        if (targets[index] > 0)
                        {
                            targets[index] -= powerShot;

                            if (targets[index] <= 0)
                            {
                                targets.Remove(targets[index]);
                            }
                        }
                    }
                }
                else if (action == "Add")
                {
                    int value = int.Parse(currentCommand[2]);

                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }

                }
                else if (action == "Strike")
                {
                    int radius = int.Parse(currentCommand[2]);                                       

                    if (index - radius >= 0 && index + radius <= targets.Count)
                    {
                        targets.RemoveRange(index - radius, radius * 2 + 1);
                    }
                    else
                    {
                        Console.WriteLine($"Strike missed!");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join('|', targets));
        }
    }
}
