using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split("\\").ToList();

            string[] extracted = input[input.Count - 1].Split('.');

            string file = extracted[0];
            string extension = extracted[1];

            Console.WriteLine($"File name: {file}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
