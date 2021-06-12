using System;

namespace _01.___Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int peopleCurrentWagon = int.Parse(Console.ReadLine());
                numbers[i] = peopleCurrentWagon;
                sum += peopleCurrentWagon;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");                
            }

            Console.WriteLine();
            Console.WriteLine($"{sum}");
        }
    }
}
