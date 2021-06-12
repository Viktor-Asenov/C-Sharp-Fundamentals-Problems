﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            string[] reversedText = new string[text.Length];

            int lastItemOfReversedText = text.Length - 1;

            for (int index = 0; index < text.Length; index++)
            {
                if (text[index] == ' ')
                {
                    lastItemOfReversedText--;
                }
                else
                {
                    reversedText[lastItemOfReversedText] += text[index];
                }
            }

            for (int index = 0; index < text.Length; index++)
            {
                Console.Write($"{string.Join(" ", reversedText[index])} ");
            }
        }
    }
}