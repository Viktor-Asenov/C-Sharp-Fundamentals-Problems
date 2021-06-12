using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"([=|\/])(?<destination>[A-Z][A-Za-z]{2,})\1";

            MatchCollection matched = Regex.Matches(input, pattern);

            int travelPoints = 0;

            List<string> destinations = new List<string>();

            foreach (Match match in matched)
            {
                string currentDestination = match.Groups["destination"].Value;
                travelPoints += currentDestination.Length;

                destinations.Add(currentDestination);
            }

            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
