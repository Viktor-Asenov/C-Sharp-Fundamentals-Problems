using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ").ToArray();
            string text = Console.ReadLine();
            
            for (int i = 0; i < bannedWords.Length; i++)
            {
                string currentWord = bannedWords[i];

                if (text.Contains(currentWord))
                {
                    text = text.Replace(currentWord, new string('*', currentWord.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
