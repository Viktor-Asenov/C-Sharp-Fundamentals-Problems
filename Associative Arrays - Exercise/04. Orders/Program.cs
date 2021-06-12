using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            var products = new Dictionary<string, Product>();
            

            while (input != "buy")
            {
                string[] productData = input.Split().ToArray();
                string nameProduct = productData[0];
                double productPrice = double.Parse(productData[1]);
                int productQuantity = int.Parse(productData[2]);

                var product = new Product
                {
                    Name = nameProduct,
                    Price = productPrice,
                    Quantity = productQuantity
                };

                if (!products.ContainsKey(product.Name))
                {
                    products[nameProduct] = product;
                    
                }
                else
                {
                    products[product.Name].Quantity += product.Quantity;

                    if (products[product.Name].Price != product.Price)
                    {
                        products[product.Name].Price = product.Price;
                    }
                }                

                input = Console.ReadLine();
            }

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Value.Name} -> {product.Value.GetTotal(product.Value.Price, product.Value.Quantity):f2}");
            }
        }
    }

    class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public double GetTotal (double price, int quantity)
        {
            double total = price * quantity;

            return total;
        }
    }
}
