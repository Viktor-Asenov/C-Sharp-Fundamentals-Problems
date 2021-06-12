using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToList();            
            int difference = 0;

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == '>')
                {
                    int indexBomb = i;
                    string power = input[i + 1].ToString();
                    int explosionStrenght = int.Parse(power) + difference;
                    int explosionStrenghtIndex = indexBomb + 1;

                    if (input[explosionStrenghtIndex + 1] == '>')
                    {
                        if (explosionStrenght <= 1)
                        {

                        }
                        else if (explosionStrenght == 2)
                        {
                            difference++;
                            explosionStrenght -= difference;                            
                        }
                        else
                        {
                            difference = (explosionStrenghtIndex + explosionStrenght) - (explosionStrenghtIndex + 1);
                            explosionStrenght -= difference;
                        }                       

                        input.RemoveRange(explosionStrenghtIndex, explosionStrenght);
                    }
                    else
                    {
                        if (explosionStrenght > input.Count)
                        {
                            break;
                        }
                        else
                        {
                            input.RemoveRange(explosionStrenghtIndex, explosionStrenght);
                            difference = 0;
                        }
                        
                    }                    
                }
            }

            Console.WriteLine(string.Join("", input));
        }
    }
}
