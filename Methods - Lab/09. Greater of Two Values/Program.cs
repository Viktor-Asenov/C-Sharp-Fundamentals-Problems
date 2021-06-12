using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();           

            switch (input)
            {
                case "int":
                    int firstValue = int.Parse(Console.ReadLine());
                    int secondValue = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMaxInt(firstValue, secondValue));
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMaxChar(firstChar, secondChar));
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    Console.WriteLine(GetMaxString(firstString, secondString));
                    break;
            }        
        }

        static int GetMaxInt (int firstValue, int secondValue)
        {
            return Math.Max(firstValue, secondValue);
        }

        static char GetMaxChar (char firstChar, char secondChar)
        {
            return (char) Math.Max(firstChar, secondChar);
        }

        static string GetMaxString (string firstString, string secondString)
        {
            int comparison = firstString.CompareTo(secondString);

            if (comparison > 0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }
    }
}
