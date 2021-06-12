using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            while (command != "Done")
            {
                string[] currentCommand = command.Split();
                string action = currentCommand[0];                               

                if (action == "TakeOdd")
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (i % 2 == 1)
                        {                            
                            result.Append(input[i]);
                        }
                    }

                    input = result.ToString();

                    Console.WriteLine(input);
                }
                else if (action == "Cut")
                {
                    int startIndex = int.Parse(currentCommand[1]);
                    int lenght = int.Parse(currentCommand[2]);

                    input = input.Remove(startIndex, lenght);
                    
                    Console.WriteLine(input);
                }
                else
                {
                    string substring = currentCommand[1];
                    string substitute = currentCommand[2];

                    if (input.Contains(substring))
                    {
                        input = input.Replace(substring, substitute);

                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine($"Nothing to replace!");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {input}");
        }
    }
}
