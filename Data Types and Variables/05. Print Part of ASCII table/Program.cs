using System;

namespace _05._Print_Part_of_ASCII_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                char current = (char)i;

                Console.Write($"{current} ");
            }
        }
    }
}
