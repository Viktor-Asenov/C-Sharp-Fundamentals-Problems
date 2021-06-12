using System;
using System.Linq;

namespace _07._Max_Sequence_in_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxLenght = 0;
            int lenght = 1;
            int start = 0;
            int bestStart = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    lenght++;
                }
                else
                {
                    lenght = 1;
                    start = i;
                }

                if (lenght > maxLenght)
                {
                    maxLenght = lenght;
                    bestStart = start;
                }
            }

            for (int i = bestStart; i < bestStart + maxLenght; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
