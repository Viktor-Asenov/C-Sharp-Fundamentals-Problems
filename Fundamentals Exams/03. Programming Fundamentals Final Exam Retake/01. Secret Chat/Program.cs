using System;
using System.Text;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string[] currentCommand = command.Split(":|:");

                if (currentCommand[0].Contains("InsertSpace"))
                {
                    int index = int.Parse(currentCommand[1]);

                    message = message.Insert(index, " ");

                    Console.WriteLine(message);
                }
                else if (currentCommand[0].Contains("Reverse"))
                {
                    string substring = currentCommand[1];
                    
                    if (message.Contains(substring))
                    {
                        message = message.Remove(message.IndexOf(substring), substring.Length);
                        StringBuilder sb = new StringBuilder();

                        for (int i = substring.Length - 1; i >= 0; i--)
                        {
                            sb.Append(substring[i]);
                        }

                        substring = sb.ToString();
                        message = message.Insert(message.Length, substring);

                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (currentCommand[0].Contains("ChangeAll"))
                {
                    string replacement = currentCommand[1];
                    string substring = currentCommand[2];                    

                    message = message.Replace(replacement, substring);

                    Console.WriteLine(message);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
