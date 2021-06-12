using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] currentArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < currentArr.Length - 1; j++)
                {
                    firstArr[i] = currentArr[j];
                    secondArr[i] = currentArr[j + 1];
                }
            }

            for (int i = 0; i < n; i += 2) //*
            {
                int temp = 0; //*
                temp = secondArr[i];
                secondArr[i] = firstArr[i];
                firstArr[i] = temp;
            }

            string firstOutput = string.Join(" ", firstArr);
            string secondOutput = string.Join(" ", secondArr);

            Console.WriteLine(secondOutput);
            Console.WriteLine(firstOutput);
 
            
        }
    }
}
