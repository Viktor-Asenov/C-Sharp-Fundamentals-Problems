using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string bestKegName = "";
            double biggestKeg = double.MinValue;

            for (int i = 0; i < n; i++)
            {
                double volumeCurrentKeg = 0;

                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                volumeCurrentKeg = 3.14 * radius * radius * height;

                if (volumeCurrentKeg > biggestKeg)
                {
                    biggestKeg = volumeCurrentKeg;
                    bestKegName = model;
                }
            }

            Console.WriteLine(bestKegName);
        }
    }
}
