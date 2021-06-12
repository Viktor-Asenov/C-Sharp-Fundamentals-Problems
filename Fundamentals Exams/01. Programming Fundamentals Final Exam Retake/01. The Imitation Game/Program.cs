using System;

namespace _01._The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Decode")
                {
                    break;
                }

                string[] commandTokens = command
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                if (commandTokens[0] == "Move")
                {
                    int numberOfLettersToMove = int.Parse(commandTokens[1]);
                    
                    for (int i = 0; i < numberOfLettersToMove; i++)
                    {
                        char currentToMove = message[0];
                        message = message.Insert(message.Length, currentToMove.ToString());
                        message = message.Remove(0, 1);
                    }
                }
                else if (commandTokens[0] == "Insert")
                {
                    int index = int.Parse(commandTokens[1]);
                    string value = commandTokens[2];

                    message = message.Insert(index, value);
                }
                else if (commandTokens[0] == "ChangeAll")
                {
                    string substringForReplacing = commandTokens[1];
                    string replacement = commandTokens[2];

                    message = message.Replace(substringForReplacing, replacement);
                }
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
