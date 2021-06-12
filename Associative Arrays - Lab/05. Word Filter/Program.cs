using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split()
                .Where(x => x.Length % 2 == 0)
                .ToArray();

            foreach (var fruit in input)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
