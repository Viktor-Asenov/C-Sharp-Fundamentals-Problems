using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, double>();

            string[] players = Console.ReadLine()
                .Split(", ");

            foreach (string player in players)
            {
                if (!dict.ContainsKey(player))
                {
                    dict[player] = 0;
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                string name = string.Empty;
                double distance = 0;

                if (input == "end of race")
                {
                    break;
                }
                else
                {
                    Regex regex = new Regex(@"[A-Za-z]");

                    MatchCollection matches = regex.Matches(input);

                    foreach (Match match in matches)
                    {
                        name += match.Value;
                    }

                    if (dict.ContainsKey(name))
                    {
                        MatchCollection matchesForDistance = Regex.Matches(input, @"[0-9]");

                        foreach (Match digit in matchesForDistance)
                        {
                            double currentKm = double.Parse(digit.Value);
                            distance += currentKm;
                        }

                        dict[name] += distance;
                    }
                }
            }

            dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine($"1st place: {dict.Keys.ElementAt(0)}");
            Console.WriteLine($"2nd place: {dict.Keys.ElementAt(1)}");
            Console.WriteLine($"3rd place: {dict.Keys.ElementAt(2)}");
        }
    }
}
