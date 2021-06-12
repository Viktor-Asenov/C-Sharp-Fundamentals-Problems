﻿using System;
using System.Linq;

namespace _03.Zig___Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < input.Length - 1; j++)
                {
                    secondArray[i] = input[j];
                    firstArray[i] = input[j + 1];
                }                
            }

            for (int i = 0; i < n; i += 2)
            {
                int temp = 0;
                temp = secondArray[i];
                secondArray[i] = firstArray[i];
                firstArray[i] = temp;
            }

            string firstOutput = string.Join(" ", firstArray);
            string secondOutput = string.Join(" ", secondArray);

            Console.WriteLine(firstOutput);
            Console.WriteLine(secondOutput);
        }
    }
}
