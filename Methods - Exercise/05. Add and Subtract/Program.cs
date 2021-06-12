using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];
            int sum = 0;            

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
                
                if (i == array.Length - 1)
                {
                    sum -= array[i];
                }
            }

           Console.WriteLine(SubtractSum(array, sum));
        }

        static int SubtractSum (int [] array, int sum)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    sum -= array[i];
                }
            }

            return sum;
        }
    }
}
