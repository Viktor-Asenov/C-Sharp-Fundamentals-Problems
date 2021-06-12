using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();
            string added = "";

            for (int i = 0; i < arr.Length; i++)
            {
                string currentWord = arr[i];

                for (int j = 0; j < currentWord.Length; j++)
                {
                    added += currentWord;
                }
            }

            Console.WriteLine(added);
        }
    }
}
