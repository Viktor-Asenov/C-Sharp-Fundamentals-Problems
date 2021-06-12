using System;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string cipher = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                char currentLetter = input[i];
                currentLetter += (char)3;
                cipher += currentLetter;
            }

            Console.WriteLine(cipher);
        }
    }
}
