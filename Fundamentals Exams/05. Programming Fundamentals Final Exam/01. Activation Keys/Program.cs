using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Generate")
            {
                string[] command = input.Split(">>>");

                string currentCommand = command[0];

                if (currentCommand == "Contains")
                {
                    string substring = command[1];                    

                    if (activationKey.Contains(substring))
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                    }
                }
                else if (currentCommand == "Flip")
                {
                    string commandForUpperOrLowerCase = command[1];
                    int startIndex = int.Parse(command[2]);
                    int endIndex = int.Parse(command[3]);

                    if (commandForUpperOrLowerCase == "Upper")
                    {
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            string replaced = activationKey[i].ToString().ToUpper();
                            activationKey = activationKey.Replace(activationKey[i].ToString(), replaced);
                        }
                    }
                    else
                    {
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            string replaced = activationKey[i].ToString().ToLower();
                            activationKey = activationKey.Replace(activationKey[i].ToString(), replaced);
                        }
                    }

                    Console.WriteLine(activationKey);
                }
                else if (currentCommand == "Slice")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    activationKey = activationKey.Remove(startIndex, endIndex - startIndex);

                    Console.WriteLine(activationKey);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
