using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int counterLine = 1;

            var dict = new Dictionary<string, int>();

            string resource = string.Empty;
            int quantity = 0;            

            while (command != "stop")
            {
                if (counterLine % 2 == 0)
                {
                    quantity = int.Parse(command);                    
                    counterLine++;
                }
                else
                {
                    resource = command;
                    counterLine++;
                }

                if (!dict.ContainsKey(resource))
                {
                    quantity = 0;
                    dict[resource] = quantity;
                }
                else
                {
                    if (dict.ContainsKey(resource) && counterLine % 2 == 0)
                    {
                        quantity = 0;
                    }

                    dict[resource] += quantity;
                }
                

                command = Console.ReadLine();
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
