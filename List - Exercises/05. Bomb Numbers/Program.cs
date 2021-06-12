using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] specialNumberAndPower = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int specialNumber = specialNumberAndPower[0];
            int power = specialNumberAndPower[1];

            int specialNumberIndex = numbers.IndexOf(specialNumber);

            while (specialNumberIndex != -1)
            {
                int leftSide = specialNumberIndex - power;
                int rightSide = specialNumberIndex + power;

                if (leftSide < 0)
                {
                    leftSide = 0;
                }
                if (rightSide > numbers.Count)
                {
                    rightSide = numbers.Count - 1;
                }

                numbers.RemoveRange(leftSide, rightSide - leftSide + 1);

                specialNumberIndex = numbers.IndexOf(specialNumber);
            }                                     
            
            Console.WriteLine(numbers.Sum());
        }
    }
}
