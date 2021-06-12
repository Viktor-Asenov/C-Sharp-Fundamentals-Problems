using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Another
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Equals('>'))
                {
                    string parsed = input[i + 1].ToString();
                    int bombStrenght = int.Parse(parsed);

                    if (bombStrenght <= 1)
                    {
                        
                    }
                    else
                    {
                        bombStrenght--;

                    }

                    input.Remove(bombStrenght);
                }
            }
        }
    }
}
