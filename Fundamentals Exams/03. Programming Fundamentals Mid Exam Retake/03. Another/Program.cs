using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Another
{
    class Program
    {
        static void Main(string[] args)
        {
            var targets = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();
            int countShooted = 0;

            while (command != "End")
            {
                int currentIndex = int.Parse(command);

                if (currentIndex > targets.Count - 1)
                {

                }
                else
                {
                    if (targets[currentIndex].Equals(-1))
                    {

                    }
                    else
                    {
                        int valueShooted = targets[currentIndex];
                        targets[currentIndex] = -1;
                        countShooted++;

                        for (int i = 0; i < targets.Count; i++)
                        {
                            if (targets[i].Equals(-1))
                            {

                            }
                            else if (targets[i] > valueShooted)
                            {
                                targets[i] -= valueShooted;
                            }
                            else
                            {
                                targets[i] += valueShooted;
                            }
                        }
                    }                    
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {countShooted} -> {string.Join(' ', targets)}");
        }
    }
}
