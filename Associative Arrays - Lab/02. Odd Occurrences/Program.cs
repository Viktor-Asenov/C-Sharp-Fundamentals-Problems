using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();

            var counts = new Dictionary<string, int>();

            foreach (var item in input)
            {
                string wordInLowerCase = item.ToLower();

                if (counts.ContainsKey(wordInLowerCase))
                {
                    counts[wordInLowerCase]++;
                }
                else
                {
                    counts.Add(wordInLowerCase, 1);
                }
            }

            foreach (var item in counts)
            {
                if (item.Value % 2 == 1)
                {
                    Console.Write($"{item.Key + " "}");
                }
            }
        }
    }
}
