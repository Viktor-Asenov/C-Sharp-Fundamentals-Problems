using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] commandParts = command.Split();

                if (commandParts[0] == "swap")
                {
                    int firstIndex = int.Parse(commandParts[1]);
                    int secondIndex = int.Parse(commandParts[2]);

                    Swap(numbers, firstIndex, secondIndex);
                }
                else if (commandParts[0] == "multiply")
                {
                    int firstIndex = int.Parse(commandParts[1]);
                    int secondIndex = int.Parse(commandParts[2]);

                    Multiply(numbers, firstIndex, secondIndex);
                }
                else if (commandParts[0] == "decrease")
                {
                    Decrease(numbers);
                }                
            }

            Console.WriteLine(string.Join(", ", numbers));
        }

        public static int[] Swap(int[] numbers, int firstIndex, int secondIndex)
        {
            int firstElement = numbers[firstIndex];
            int secondElement = numbers[secondIndex];

            numbers[firstIndex] = secondElement;
            numbers[secondIndex] = firstElement;

            return numbers;
        }

        public static int[] Multiply(int[] numbers, int firstIndex, int secondIndex)
        {
            int firstNumber = numbers[firstIndex];
            int secondNumber = numbers[secondIndex];
            int product = firstNumber * secondNumber;
            numbers[firstIndex] = product;

            return numbers;
        }

        public static int[] Decrease(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] -= 1;
            }

            return numbers;
        }
    }
}
