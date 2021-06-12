using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] splitOptions = { ',', ' ', ':', '-' };

            List<string> items = Console.ReadLine().Split(splitOptions, StringSplitOptions.RemoveEmptyEntries ).ToList();
            
            string command = Console.ReadLine();

            while (command != "Craft!")
            {
                List<string> currentCommand = command.Split(splitOptions, StringSplitOptions.RemoveEmptyEntries).ToList();
                
                string item = currentCommand[1];

                if (currentCommand[0] == "Collect")
                {
                    if (items.Contains(item))
                    {
                        
                    }
                    else
                    {
                        items.Add(item);
                    }
                }
                else if (currentCommand[0] == "Drop")
                {
                    if (items.Contains(item))
                    {
                        items.Remove(item);
                    }                    
                }
                else if (currentCommand[0] == "Combine" && currentCommand[1] == "Items")
                { 
                    string oldItem = currentCommand[2];
                    string newItem = currentCommand[3];                    

                    if (items.Contains(oldItem))
                    {
                        for (int i = 0; i < items.Count; i++)
                        {
                            if (items[i] == oldItem)
                            {
                                items.Insert(i + 1, newItem);
                            }
                        }
                    }                    
                }
                else if (currentCommand[0] == "Renew")
                {
                    if (items.Contains(item))
                    {
                        items.Add(item);
                        items.RemoveAt(items.IndexOf(item));
                    }
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < items.Count; i++)
            {
                if (i == items.Count - 1)
                {
                    Console.Write(items[i] + ' ');
                }
                else
                {
                    Console.Write(items[i] + ',' + ' ');
                }
            }
        }
    }
}
