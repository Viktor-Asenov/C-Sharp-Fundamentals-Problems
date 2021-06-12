using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            string currentName = "";

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] currentCommand = Console.ReadLine().Split();
                currentName = currentCommand[0];                

                if (currentCommand[1] == "is" && currentCommand[2] == "going!")
                {
                    if (names.Contains(currentName))
                    {
                        Console.WriteLine($"{currentName} is already in the list!");                        
                    }
                    else
                    {
                        names.Add(currentName);
                    }                    
                }
                else
                {
                    if (names.Contains(currentName))
                    {
                        names.Remove(currentName);
                    }
                    else
                    {
                        Console.WriteLine($"{currentName} is not in the list!");
                    }
                }
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
