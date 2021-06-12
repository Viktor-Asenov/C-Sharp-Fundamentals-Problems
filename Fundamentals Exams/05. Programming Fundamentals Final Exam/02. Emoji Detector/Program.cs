using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Numerics;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {                  
            string input = Console.ReadLine();

            BigInteger coolThreshold = 1;

            foreach (var symbol in input)
            {
                if (char.IsDigit(symbol) && symbol != 0)
                {
                    string current = symbol.ToString();
                    int currentDigit = int.Parse(current);

                    coolThreshold *= currentDigit;
                }
            }
            
            string pattern = @"([:]{2}|[*]{2})(?<emoji>[A-Z][a-z]{2,})\1";

            var matched = Regex.Matches(input, pattern);

            List<string> coolEmojis = new List<string>();

            int countEmojis = 0;
 
            foreach (Match match in matched)
            {
                string emoji = match.Groups["emoji"].Value;

                int sumLetters = 0;

                foreach ( var symbol in emoji)
                {
                    sumLetters += symbol;
                }

                if (sumLetters > coolThreshold)
                {
                    coolEmojis.Add(match.ToString());
                }

                countEmojis++;
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{countEmojis} emojis found in the text. The cool ones are:");
            Console.WriteLine(string.Join(Environment.NewLine, coolEmojis));
            
        }
    }
}
