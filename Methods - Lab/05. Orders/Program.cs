using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            PrintSumProducts(product, quantity);
        }

        static void PrintSumProducts (string product, int quantity)
        {
            double priceProduct = 0;

            switch (product)
            {
                case "coffee":
                    priceProduct = 1.5;
                    break;
                case "water":
                    priceProduct = 1;
                    break;
                case "coke":
                    priceProduct = 1.4;
                    break;
                case "snacks":
                    priceProduct = 2;
                    break;                    
            }

            Console.WriteLine($"{priceProduct * quantity:f2}");
        }
    }
}
