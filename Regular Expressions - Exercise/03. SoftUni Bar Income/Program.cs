using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<quantity>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";

            string customer = string.Empty;
            string product = string.Empty;
            int quantity = 0;
            decimal price = 0;
            decimal totalCurrent = 0;
            decimal totalWholeOrders = 0;

            while (input != "end of shift")
            {
                string data = input;

                var matched = Regex.Matches(data, pattern);

                foreach (Match order in matched)
                {
                    customer = order.Groups["customer"].Value;
                    product = order.Groups["product"].Value;
                    quantity = int.Parse(order.Groups["quantity"].Value);
                    price = decimal.Parse(order.Groups["price"].Value);
                    totalCurrent = price * quantity;
                    totalWholeOrders += totalCurrent;

                    Console.WriteLine($"{customer}: {product} - {totalCurrent:f2}");
                }

                
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalWholeOrders:f2}");
        }
    }
}
