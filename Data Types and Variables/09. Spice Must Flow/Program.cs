using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int extracted = 0;
            int countDays = 0;
            int sumExtracted = 0;

            while (startingYield >= 100)
            {
                extracted = startingYield;
                extracted -= 26;
                startingYield -= 10;
                countDays++;
                sumExtracted += extracted;
            }

            if (startingYield < 100)
            {
                if (sumExtracted < 26)
                {
                    sumExtracted = sumExtracted;
                }
                else
                {
                    sumExtracted -= 26;
                }                
            }

            Console.WriteLine(countDays);
            Console.WriteLine(sumExtracted);
        }
    }
}
