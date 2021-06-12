using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            Console.WriteLine(GetValue(num, power));
        }

        static double GetValue (double num, double power)
        {
            double result = 1;

            for (int i = 0; i < power; i++)
            {                
                result *= num;               
            }

            return result;
        }
    }
}
