using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    public class Product
    {
        public string Name { get; set; }

        public string ExpirationDate { get; set; }

        public int Calories { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            string foodData = Console.ReadLine();

            string pattern = @"([#\|])(?<item>[A-Za-z\s]+)\1(?<expirationDate>\d{2}\/\d{2}\/\d{2})*\1(?<calories>[\d]+)\1";

            MatchCollection matched = Regex.Matches(foodData, pattern);

            List<Product> products = new List<Product>();
            int totalCalories = 0;

            foreach (Match match in matched)
            {
                string productName = match.Groups["item"].Value;
                string expirationDate = match.Groups["expirationDate"].Value;
                int calories = int.Parse(match.Groups["calories"].Value);

                Product product = new Product
                {
                    Name = productName,
                    ExpirationDate = expirationDate,
                    Calories = calories
                };

                totalCalories += product.Calories;
                products.Add(product);
            }

            int days = totalCalories / 2000;

            Console.WriteLine($"You have food to last you for: { days} days!");

            foreach (var product in products)
            {
                Console.WriteLine($"Item: {product.Name}, Best before: {product.ExpirationDate}, Nutrition: {product.Calories}");
            }
        }
    }
}
