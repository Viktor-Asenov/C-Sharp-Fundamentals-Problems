using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int countVowels = 0;

            Console.WriteLine(GetNumberOfVowels(input, countVowels));
        }

        static int GetNumberOfVowels(string input, int countVowels)
        {
            for (int i = 0; i < input.Length; i++)
            {                
                if (input[i] == 'A' || input[i] == 'a' || input[i] == 'U' || input[i] == 'u' || input[i] == 'O'
                    || input[i] == 'o' || input[i] == 'E' || input[i] == 'e' || input[i] == 'I' || input[i] == 'i')
                {
                    countVowels++;
                }
            }

            return countVowels;
        }
    }
}

        
        

        
    

