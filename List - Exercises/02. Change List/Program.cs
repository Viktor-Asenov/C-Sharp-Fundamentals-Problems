using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();

            int currentNum = 0;
            int index = 0;

            while (input != "end")
            {
                string[] currentCommand = input.Split();

                if (currentCommand[0] == "Delete")
                {
                    Delete(numbers, currentNum, currentCommand);
                }
                else if (currentCommand[0] == "Insert")
                {
                    Insert(numbers, currentNum, currentCommand, index);
                } 

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static List<int> Delete (List<int> numbers, int currentNum, string[] currentCommand)
        {
            currentNum = int.Parse(currentCommand[1]);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == currentNum)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            return numbers;
        }

        static List<int> Insert (List<int> numbers, int currentNum, string[] currentCommand, int index)
        {
            currentNum = int.Parse(currentCommand[1]);
            index = int.Parse(currentCommand[2]);

            numbers.Insert(index, currentNum);

            return numbers;
        }
    }
}
