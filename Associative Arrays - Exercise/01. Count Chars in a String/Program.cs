using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> transformedInput = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                var currentChar = input[i].ToString();
                transformedInput.Add(currentChar);
            }

            var dict = new Dictionary<string, int>();

            foreach (var item in transformedInput)
            {
                if (!dict.ContainsKey(item))
                {
                    dict[item] = 0;
                }

                dict[item]++;
            }

            foreach (var item in dict)
            {
                if (item.Key == " ")
                {

                }
                else
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }                
            }
        }
    }
}
