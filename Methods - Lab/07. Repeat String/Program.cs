using System;
using System.Linq;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] converted = new string[1];
            int n = int.Parse(Console.ReadLine());
            converted[0] = input;

            CreateNewArray(converted, n);
        }

        static void CreateNewArray(string[] converted, int n)
        {
            string[] newArr = new string[converted.Length * n];

            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = converted[0];
            }

            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write(newArr[i]);
            }
        }
    }
}
