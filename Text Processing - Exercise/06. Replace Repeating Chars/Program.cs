using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToList();            

            for (int i = 0; i < input.Count; i++)
            {
                if (i + 1 == input.Count)
                {
                    break;
                }
                else
                {
                    char currentChar = input[i];
                    char next = input[i + 1];

                    if (currentChar == next)
                    {
                        input.RemoveAt(i);
                        i--;
                    }
                }              
               
            }

            Console.WriteLine(string.Join("", input));
        }
    }
}
