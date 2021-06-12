using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();

            foreach (var username in input)
            {
                if (validateUsername(username))
                {
                    Console.WriteLine(username);
                }
            }
        }

        static bool validateUsername(string username)
        {
            if (username.Length < 3 || username.Length > 16)
            {
                return false;
            }

            for (int i = 0; i < username.Length; i++)
            {
                char symbol = username[i];

                if (!char.IsLetterOrDigit(symbol) && symbol != '-' && symbol != '_')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
