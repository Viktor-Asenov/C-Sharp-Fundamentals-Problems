using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(@|#)(?<first>[A-Za-z]{3,})(\1{2})(?<second>[A-Za-z]{3,})\1";

            MatchCollection matched = Regex.Matches(input, pattern);

            var pairs = new List<string>();

            foreach (Match match in matched)
            {
                string firstWord = match.Groups["first"].Value;
                string secondWord = match.Groups["second"].Value;
                string converted = "";

                StringBuilder sb = new StringBuilder();

                for (int i = secondWord.Length - 1; i >= 0; i--)
                {
                    sb.Append(secondWord[i]);
                }

                converted = sb.ToString();

                if (firstWord == converted)
                {
                    pairs.Add(string.Join(" <=> ", firstWord, secondWord));
                }
            }

            if (matched.Count > 0)
            {
                Console.WriteLine($"{matched.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }
            
            if (pairs.Count > 0)
            {
                Console.WriteLine("The mirror words are:");

                for (int i = 0; i < pairs.Count; i++)
                {
                    if (i == pairs.Count - 1)
                    {
                        Console.WriteLine($"{pairs[i]}");
                    }
                    else
                    {
                        Console.Write($"{pairs[i]}, ");
                    }
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
