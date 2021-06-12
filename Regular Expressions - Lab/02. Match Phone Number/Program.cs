using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\+359(\s|-)([2])\1(\d{3})\1(\d{4})\b";

            string phoneNumbers = Console.ReadLine();

            MatchCollection phoneMatches = Regex.Matches(phoneNumbers, regex);

            var matchedPhones = phoneMatches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
