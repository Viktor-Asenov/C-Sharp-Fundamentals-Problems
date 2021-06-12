using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace _06._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] input = command.Split();                

                string serialNumber = input[0];
                string itemName = input[1];
                int itemQuantity = int.Parse(input[2]);
                double itemPrice = double.Parse(input[3]);

                Box box = new Box();

                box.SerialNumber = serialNumber;
                box.Item.Name = itemName;
                box.Quantity = itemQuantity;
                box.Item.Price = itemPrice;

                box.PriceBox = itemQuantity * itemPrice;               

                boxes.Add(box);

                command = Console.ReadLine();
            }

            var newListBoxes = boxes.OrderByDescending(x => x.PriceBox).ToList();
            
            foreach ( var box in newListBoxes)
            {                
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceBox:f2}");
            }
        }
    }
    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }

        public int Quantity { get; set; }

        public double PriceBox { get; set; }

    }

    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
