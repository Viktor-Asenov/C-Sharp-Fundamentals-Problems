﻿using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> productList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();

                productList.Add(product);
            }

            productList.Sort();

            for (int i = 0; i < productList.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{productList[i]}");
            }

        }
    }
}