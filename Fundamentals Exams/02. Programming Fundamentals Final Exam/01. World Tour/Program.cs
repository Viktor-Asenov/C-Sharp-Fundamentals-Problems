using System;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] splitOptions = {" ", ":" };

            while (true)
            {
                string command = Console.ReadLine();

                if(command == "Travel")
                {
                    break;
                }

                string[] commandParts = command.Split(splitOptions, StringSplitOptions.RemoveEmptyEntries);

                if (commandParts[0] == "Add")
                {
                    int index = int.Parse(commandParts[2]);
                    string stop = commandParts[3];

                    if (index >= 0 && index <= input.Length && stop != " ")
                    {
                        input = input.Insert(index, stop);
                    }

                    Console.WriteLine(input);
                }
                else if (commandParts[0] == "Remove")
                {
                    int startIndex = int.Parse(commandParts[2]);
                    int endIndex = int.Parse(commandParts[3]);

                    if (startIndex >= 0 && startIndex < input.Length
                        && endIndex >= 0 && endIndex < input.Length)
                    {
                        input = input.Remove(startIndex, endIndex - startIndex + 1);
                    }

                    Console.WriteLine(input);
                }
                else if (commandParts[0] == "Switch")
                {
                    string oldString = commandParts[1];
                    string newString = commandParts[2];

                    if (input.Contains(oldString))
                    {
                        input = input.Replace(oldString, newString);
                    }

                    Console.WriteLine(input);
                }
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {input}");
        }
    }
}
