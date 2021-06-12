using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var specialItems = new Dictionary<string, int>();
            var junk = new Dictionary<string, int>();

            specialItems.Add("shards", 0);
            specialItems.Add("fragments", 0);
            specialItems.Add("motes", 0);

            string keyWord = string.Empty;
            bool hasToBreak = false;
            
            while (!hasToBreak)
            {
                string[] input = Console.ReadLine().Split().ToArray();                

                for (int i = 0; i < input.Length; i+=2)
                {                    
                    int currentItemQuantity = int.Parse(input[i]);
                    string item = input[i + 1].ToLower();

                    if (item == "shards" || item == "fragments" || item == "motes")
                    {
                        keyWord = item;
                        specialItems[keyWord] += currentItemQuantity;

                        if (specialItems[keyWord] >= 250)
                        {
                            if (keyWord == "shards")
                            {
                                specialItems[keyWord] -= 250;
                                keyWord = "Shadowmourne";
                            }
                            else if (keyWord == "fragments")
                            {
                                specialItems[keyWord] -= 250;
                                keyWord = "Valanyr";
                            }
                            else if (keyWord == "motes")
                            {
                                specialItems[keyWord] -= 250;
                                keyWord = "Dragonwrath";
                            }

                            hasToBreak = true;
                            Console.WriteLine($"{keyWord} obtained!");
                            break;
                        }                        
                    }
                    else
                    {
                        if (!junk.ContainsKey(item))
                        {
                            junk[item] = 0;
                        }

                        junk[item] += currentItemQuantity;
                    }
                }
            }

            if (specialItems.Count > 0)
            {
                var resultSpecialItems = specialItems
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

                foreach (var item in resultSpecialItems)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }

            if (junk.Count > 0)
            {
                var resultJunk = junk.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

                foreach (var item in resultJunk)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }            
        }
    }
}
