using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine();

            int startIndex = 0;
            int endIndex = 0;
            int index = 0;
            int partitions = 0;

            while (command != "3:1")
            {
                string[] currentCommand = command.Split();
                string action = currentCommand[0];

                if (action == "merge")
                {
                    Merge(input, startIndex, endIndex, currentCommand);                    
                }
                else if (action == "divide")
                {
                    Divide(input, index, partitions, currentCommand);
                }
                

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", input));
        }

        static List<string> Merge (List<string> input, int startIndex, int endIndex, string[] currentCommand)
        {
            startIndex = int.Parse(currentCommand[1]);
            endIndex = int.Parse(currentCommand[2]);            

            string concatenatedInput = "";
                        
            if (startIndex < 0)
            {
                if (endIndex >= 0 && endIndex < input.Count - 1)
                {
                    startIndex = 0;
                }
            }
            
            if (endIndex > input.Count - 1)
            {
                if (startIndex >= 0 && startIndex <= input.Count - 1)
                {
                    endIndex = input.Count - 1;
                }
            }

            if (startIndex >= 0 && startIndex <= input.Count - 1 && endIndex >= 0 && endIndex <= input.Count - 1)
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    concatenatedInput += input[i];

                }

                input.RemoveRange(startIndex, endIndex - startIndex + 1);
                input.Insert(startIndex, concatenatedInput);
            }            

            return input;
        }

        static List<string> Divide (List<string> input, int index, int partitions, string[] currentCommand)
        {
            index = int.Parse(currentCommand[1]);
            partitions = int.Parse(currentCommand[2]);

            if (index >= 0 && index <= input.Count - 1)
            {
                string word = input[index];
                List<string> dividedString = new List<string>();
                int stringLenghtToAdd = word.Length / partitions;
                int startIndex = 0;

                for (int i = 0; i < partitions; i++)
                {
                    if (i == partitions - 1)
                    {
                        dividedString.Add(word.Substring(startIndex, word.Length - startIndex));
                    }
                    else
                    {
                        dividedString.Add(word.Substring(startIndex, stringLenghtToAdd));
                        startIndex += stringLenghtToAdd;
                    }
                }

                input.RemoveAt(index);
                input.InsertRange(index, dividedString);
            }

            return input;
        }
    }
}
