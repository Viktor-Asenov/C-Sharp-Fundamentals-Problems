using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shoot_For_The_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();            
            int shootedTargets = 0;

            while (command != "End")
            {
                int currentIndex = int.Parse(command);
                int targetForShooting = currentIndex;                

                if (targetForShooting > targets.Count - 1)
                {
                    
                }
                else 
                {                    

                    if (targets[targetForShooting] != -1 && targetForShooting != targets.Count - 1)
                    {
                        int valueShooted = targets[targetForShooting];
                        targets[targetForShooting] = -1;

                        for (int i = 0; i < targets.Count; i++)
                        {
                            if (targets[i] != -1 && targets[i] > targets[targetForShooting])
                            {
                                targets[i] -= valueShooted;
                            }
                            else if (targets[i] != -1 && targets[i] <= targets[targetForShooting])
                            {
                                targets[i] += valueShooted;
                            }                            
                        }
                        
                        shootedTargets++;
                    }
                    else
                    {
                        int valueShooted = targets[targetForShooting];
                        targets[targetForShooting] = -1;

                        for (int i = 0; i < targets.Count; i++)
                        {
                            if (targets[i] != -1 && targets[i] > targets[targetForShooting])
                            {
                                targets[i] -= valueShooted;
                            }
                            else if (targets[i] != -1 && targets[i] <= targets[targetForShooting])
                            {
                                targets[i] += valueShooted;
                            }                            
                        }
                        
                        shootedTargets++;
                    }
                }
              
                command = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {shootedTargets} -> {string.Join(' ', targets)}");
        }
    }
}
