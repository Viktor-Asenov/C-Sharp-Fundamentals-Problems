using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];
            int minValue = int.MaxValue;

            Console.WriteLine(GetMinValue(array, minValue));
        }

        static int GetMinValue (int [] array, int minValue)
        {           

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

                if (minValue > array[i])
                {
                    minValue = array[i];
                }
            }

            return minValue;
        }
    }
}
