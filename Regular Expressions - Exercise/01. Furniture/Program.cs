using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)";

            List<string> furnitures = new List<string>();

            decimal total = 0;

            while (input != "Purchase")
            {
                string current = input;                

                Match matched = Regex.Match(current, pattern, RegexOptions.IgnoreCase);

                if (matched.Success)
                {
                    string name = matched.Groups["name"].Value;
                    decimal price = decimal.Parse(matched.Groups["price"].Value);
                    int quantity = int.Parse(matched.Groups["quantity"].Value);

                    furnitures.Add(name);
                    total += price * quantity;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Bought furniture:");

            foreach ( var name in furnitures)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine($"Total money spend: {total:f2}");
        }
    }
}
