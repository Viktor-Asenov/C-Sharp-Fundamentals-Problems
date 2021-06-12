using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            List<int> result = new List<int>(input);

            for (int i = 0; i < input.Count; i++)
            {
                if (i == n)
                {
                    break;
                }

                result.Remove(input[i]);
                result.Add(input[i]);
            }

            for (int i = 0; i < result.Count; i++)
            {
                Console.Write($"{result[i]} ");
            }
        }
    }
}
