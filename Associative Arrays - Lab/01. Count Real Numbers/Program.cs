using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            SortedDictionary<int, int> sortedNumbers = new SortedDictionary<int, int>();

            foreach (var number in numbers)
            {
                if (sortedNumbers.ContainsKey(number))
                {
                    sortedNumbers[number]++;
                }
                else
                {
                    sortedNumbers.Add(number, 1);
                }
            }

            foreach (var number in sortedNumbers)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
