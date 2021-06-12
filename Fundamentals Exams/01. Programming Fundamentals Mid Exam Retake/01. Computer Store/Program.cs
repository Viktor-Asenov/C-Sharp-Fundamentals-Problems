using System;

namespace _01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string commandOrPrice = Console.ReadLine();
            double sumPricePartsWithoutTaxes = 0;
            double sumTaxes = 0;

            while (commandOrPrice != "special" && commandOrPrice != "regular")
            {
                double currentPrice = double.Parse(commandOrPrice);

                if (currentPrice != 0 && currentPrice > 0)
                {
                    double taxCurrentPrice = currentPrice * 0.20;
                    sumPricePartsWithoutTaxes += currentPrice;
                    sumTaxes += taxCurrentPrice;
                }
                else
                {
                    Console.WriteLine("Invalid price!");
                }

                commandOrPrice = Console.ReadLine();
            }

            double totalPrice = sumTaxes + sumPricePartsWithoutTaxes;

            if (commandOrPrice == "special" && totalPrice > 0)
            {                
                double discountedPrice = totalPrice - totalPrice * 0.10;
                totalPrice = discountedPrice;                
            }
            else if (commandOrPrice == "special" && totalPrice <= 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            else if (commandOrPrice == "regular" && totalPrice <= 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            
            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {sumPricePartsWithoutTaxes:f2}$");
            Console.WriteLine($"Taxes: {sumTaxes:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalPrice:f2}$");
        }
    }
}
