using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();            

            GetMiddleChar(input);         
        }

        static void GetMiddleChar (string input)
        {
            if (input.Length % 2 == 1)
            {                
                Console.WriteLine(input[input.Length / 2]);
            }
            else
            {                
                Console.Write($"{input[input.Length / 2 - 1]}{input[input.Length / 2]}");
            }
        }
    }
}
