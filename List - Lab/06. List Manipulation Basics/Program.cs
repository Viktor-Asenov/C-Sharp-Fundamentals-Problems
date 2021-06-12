using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();
            int currentNum = 0;
            int currentIndex = 0;

            while (input != "end")
            {
                string[] currentCommand = input.Split();                

                if (currentCommand[0] == "Add")
                {
                    Add(numbers, currentNum, currentCommand);
                }
                else if (currentCommand[0] == "Remove")
                {
                    Remove(numbers, currentNum, currentCommand);
                }
                else if (currentCommand[0] == "RemoveAt")
                {
                    RemoveAt(numbers, currentIndex, currentCommand);
                }
                else if (currentCommand[0] == "Insert")
                {
                    Insert(numbers, currentNum, currentIndex, currentCommand);
                }
                else if (currentCommand[0] == "Contains")
                {

                }
                else if (currentCommand[0] == "PrintEven")
                {

                }
                else if (currentCommand[0] == "PrintOdd")
                {

                }
                else if (currentCommand[0] == "GetSum")
                {

                }
                else if (currentCommand[0] == "Filter" && currentCommand[1] == ">=")
                {

                }
                else if (currentCommand[0] == "Filter" && currentCommand[1] == "<")
                {

                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static List<int> Add(List<int> numbers, int currentNum, string[] currentCommand)
        {
            currentNum = int.Parse(currentCommand[1]);
            numbers.Add(currentNum);

            return numbers;
        }

        static List<int> Remove (List<int> numbers, int currentNum, string[] currentCommand)
        {
            currentNum = int.Parse(currentCommand[1]);
            numbers.Remove(currentNum);

            return numbers;
        }

        static List<int> RemoveAt (List<int> numbers, int currentIndex, string[] currentCommand)
        {
            currentIndex = int.Parse(currentCommand[1]);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == currentIndex)
                {
                    numbers.RemoveAt(currentIndex);                   
                }
            }

            return numbers;
        }

        static List<int> Insert (List<int> numbers, int currentNum, int currentIndex, string[] currentCommand)
        {
            currentNum = int.Parse(currentCommand[1]);
            currentIndex = int.Parse(currentCommand[2]);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == currentIndex)
                {
                    numbers.Insert(currentIndex, currentNum);
                }
            }

            return numbers;
        }
    }
}
