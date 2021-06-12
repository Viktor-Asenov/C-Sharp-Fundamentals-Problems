using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();
            int currentNum = 0;
            int index = 0;
            int countTimes = 0;

            while (input != "End")
            {
                string[] currentCommand = input.Split();

                if (currentCommand[0] == "Add")
                {
                    Add(numbers, currentNum, currentCommand);
                }
                else if (currentCommand[0] == "Insert")
                {
                    Insert(numbers, currentNum, index, currentCommand);
                }
                else if (currentCommand[0] == "Remove")
                {
                    RemoveAt(numbers, index, currentCommand);
                }
                else if (currentCommand[0] == "Shift" && currentCommand[1] == "left")
                {
                    ShiftLeft(numbers, countTimes, currentCommand);
                }
                else if (currentCommand[0] == "Shift" && currentCommand[1] == "right")
                {
                    ShiftRight(numbers, countTimes, currentCommand);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static List<int> Add (List<int> numbers, int currentNum, string[] currentCommand)
        {
            currentNum = int.Parse(currentCommand[1]);

            numbers.Add(currentNum);

            return numbers;
        }

        static List<int> Insert (List<int> numbers, int currentNum, int index, string[] currentCommand)
        {
            currentNum = int.Parse(currentCommand[1]);
            index = int.Parse(currentCommand[2]);

            if (index >= 0 && index < numbers.Count)
            {
                numbers.Insert(index, currentNum);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }

            return numbers;
        }

        static List<int> RemoveAt (List<int> numbers, int index, string[] currentCommand)
        {
            index = int.Parse(currentCommand[1]);

            if (index >= numbers.Count || index < 0)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                numbers.RemoveAt(index);
            }            

            return numbers;
        }

        static List<int> ShiftLeft(List<int> numbers, int countTimes, string[] currentCommand)
        {
            countTimes = int.Parse(currentCommand[2]);            

            for (int i = 0; i < countTimes; i++)
            {
                numbers.Add(numbers[0]);
                numbers.Remove(numbers[0]);
            }

            return numbers;
        }

        static List<int> ShiftRight (List<int> numbers, int countTimes, string[] currentCommand)
        {
            countTimes = int.Parse(currentCommand[2]);            

            for (int i = 0; i < countTimes; i++)            
            {
                int lastNumber = numbers[numbers.Count - 1];
                
                numbers.Remove(lastNumber);
                numbers.Insert(0, lastNumber);
            }

            return numbers;
        }
    }
}
