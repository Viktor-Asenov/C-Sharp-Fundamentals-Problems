using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();
            int currentNum = 0;
            int currentIndex = 0;
            int sum = 0;
            string[] currentCommand = new string[input.Length];
            bool isChanged = false;

            while (input != "end")
            {
                currentCommand = input.Split();

                if (currentCommand[0] == "Add")
                {
                    Add(numbers, currentNum, currentCommand);
                    isChanged = true;
                }
                else if (currentCommand[0] == "Remove")
                {
                    Remove(numbers, currentNum, currentCommand);
                    isChanged = true;
                }
                else if (currentCommand[0] == "RemoveAt")
                {
                    RemoveAt(numbers, currentIndex, currentCommand);
                    isChanged = true;
                }
                else if (currentCommand[0] == "Insert")
                {
                    Insert(numbers, currentNum, currentIndex, currentCommand);
                    isChanged = true;
                }
                else if (currentCommand[0] == "Contains")
                {
                    Contains(numbers, currentNum, currentCommand);
                }
                else if (currentCommand[0] == "PrintEven")
                {
                    PrintEven(numbers);
                }
                else if (currentCommand[0] == "PrintOdd")
                {
                    PrintOdd(numbers);
                }
                else if (currentCommand[0] == "GetSum")
                {
                    Console.WriteLine(GetSum(numbers, sum));
                }
                else if (currentCommand[0] == "Filter" && currentCommand[1] == ">=")
                {
                    FilterHigherOrEqual(numbers, currentNum, currentCommand);
                }
                else if (currentCommand[0] == "Filter" && currentCommand[1] == "<")
                {
                    FilterSmallerThan(numbers, currentNum, currentCommand);
                }

                input = Console.ReadLine();
            }
            
            if (isChanged == true)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        static List<int> Add(List<int> numbers, int currentNum, string[] currentCommand)
        {
            currentNum = int.Parse(currentCommand[1]);
            numbers.Add(currentNum);

            return numbers;
        }

        static List<int> Remove(List<int> numbers, int currentNum, string[] currentCommand)
        {
            currentNum = int.Parse(currentCommand[1]);
            numbers.Remove(currentNum);

            return numbers;
        }

        static List<int> RemoveAt(List<int> numbers, int currentIndex, string[] currentCommand)
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

        static List<int> Insert(List<int> numbers, int currentNum, int currentIndex, string[] currentCommand)
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

        static void Contains (List<int> numbers, int currentNum, string [] currentCommand)
        {            
            currentNum = int.Parse(currentCommand[1]);

            if (numbers.Contains(currentNum))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }            
        }

        static void PrintEven (List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write(numbers[i] + " ");                    
                }
            }

            Console.WriteLine();
        }

        static void PrintOdd (List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.Write(numbers[i] + " ");
                }
            }

            Console.WriteLine();
        }

        static int GetSum (List<int> numbers, int sum)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        static void FilterHigherOrEqual(List<int> numbers, int currentNum, string [] currentCommand)
        {
            currentNum = int.Parse(currentCommand[2]);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= currentNum )
                {
                    Console.Write(numbers[i] + " ");
                }
            }

            Console.WriteLine();
        }

        static void FilterSmallerThan(List<int> numbers, int currentNum, string [] currentCommand)
        {
            currentNum = int.Parse(currentCommand[2]);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < currentNum)
                {
                    Console.Write(numbers[i] + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
