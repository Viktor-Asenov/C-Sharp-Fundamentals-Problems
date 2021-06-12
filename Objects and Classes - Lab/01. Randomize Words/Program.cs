using System;
using System.Collections.Generic;
using System.Linq;


namespace _01._Randomize_Words
{
    class Program
    {
        public static void Main()
        {
            var random = new Random();            

            List<string> input = Console.ReadLine().Split().ToList();                     

            for (int i = 0; i < input.Count; i++)
            {
                var randomIndex = random.Next(0, input.Count);
                var randomElement = input[randomIndex];
                var element = input[i];

                input[randomIndex] = element;
                input[i] = randomElement;
            }

            foreach ( var number in input)
            {
                Console.WriteLine(number);
            }
           
        }
    }
}
