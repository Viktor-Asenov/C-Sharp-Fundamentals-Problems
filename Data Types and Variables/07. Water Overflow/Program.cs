using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tankCapacity = 0;

            for (int i = 0; i < n; i++)
            {
                int currentLiters = int.Parse(Console.ReadLine());
                tankCapacity += currentLiters;

                if (tankCapacity > 255)
                {
                    tankCapacity -= currentLiters;
                    Console.WriteLine("Insufficient capacity!");
                }                

            }

            Console.WriteLine(tankCapacity);
        }
    }
}
