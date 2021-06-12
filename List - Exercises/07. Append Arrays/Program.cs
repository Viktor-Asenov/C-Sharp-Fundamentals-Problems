using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbersAsString = Console.ReadLine().Split('|').Reverse().ToList();
            List<int> numbers = new List<int>();

            for (int i = 0; i < numbersAsString.Count; i++)
            {
                numbers.AddRange(numbersAsString[i].Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToList()
                         );
            }          
            
            Console.WriteLine(string.Join(" ", numbers));            
        }
    }
}
