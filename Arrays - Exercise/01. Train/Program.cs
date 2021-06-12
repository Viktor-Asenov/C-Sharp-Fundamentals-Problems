using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] peopleinWagons = new int[n] ;
            int sum = 0;

            for (int i = 0; i < peopleinWagons.Length; i++)
            {
                peopleinWagons[i] = int.Parse(Console.ReadLine());
                sum += peopleinWagons[i];                
            }
            for (int i = 0; i < peopleinWagons.Length; i++)
            {
                Console.Write(peopleinWagons[i] + " ");                
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
