using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());            

            for (int i = 0; i < n; i++)
            {
                int firstElement = input[0];

                int[] temp = new int[input.Length];

                for (int j = 1; j < input.Length; j++)
                {
                    temp[j - 1] = input[j];
                    temp[temp.Length - 1] = firstElement;
                }

                input = temp;
            }

            Console.WriteLine(String.Join(' ', input));

        }
    }
}
