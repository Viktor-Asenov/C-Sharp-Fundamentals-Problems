using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.__Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string resultDigits = "";
            string resultLetters = "";
            string resultOtherSymbols = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]) )
                {
                    resultDigits += input[i];
                }
                else if (char.IsLetter(input[i]))
                {
                    resultLetters += input[i];
                }
                else
                {
                    resultOtherSymbols += input[i];
                }
            }

            Console.WriteLine(resultDigits);
            Console.WriteLine(resultLetters);
            Console.WriteLine(resultOtherSymbols);
        }
    }
}
