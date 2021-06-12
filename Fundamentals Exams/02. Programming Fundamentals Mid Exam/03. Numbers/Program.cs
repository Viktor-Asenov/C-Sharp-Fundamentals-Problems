using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            List<double> product = new List<double>();

            double average = numbers.Average();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > average)
                {
                    product.Add(numbers[i]);
                }
            }

            if (product.Count == 0)
            {
                Console.WriteLine("No");
            }
            else if (product.Count >= 5)
            {
                product = product                    
                    .OrderByDescending(n => n)
                    .ToList();

                StringBuilder result = new StringBuilder();

                for (int i = 0; i < 5; i++)
                {
                    result.Append($"{product[i]} ");
                }

                Console.WriteLine(result);
            }
            else
            {
                product = product.OrderByDescending(n => n).ToList();
                Console.WriteLine(string.Join(" ", product));
            }
        }
    }
}
