﻿using System;

namespace _01._DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = new string[7]
           {
                "Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"
           };

            int day = int.Parse(Console.ReadLine());

            if (day < 1 || day > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(daysOfWeek[day - 1]);
            }            
        }
    }
}
