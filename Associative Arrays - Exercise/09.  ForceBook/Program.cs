using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.__ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            var forceUsers = new Dictionary<string, List<string>>();
            var firstSide = new List<string>();
            var secondSide = new List<string>();     
            
            while (command != "Lumpawaroo")
            {
                string[] input = command.Split();

                string currentCommand = input[1];

                if (currentCommand == "|")
                {
                    string forceSide = input[0];
                    string forceUser = input[2];

                    if (!forceUsers.ContainsKey(forceUser))
                    {
                        
                    }

                    forceUsers[forceUser].Add(forceUser);

                }
                else
                {
                    string forceUser = input[0];
                    string forceSide = input[2];

                    if (!forceUsers.ContainsKey(forceSide))
                    {
                        firstSide = new List<string>();
                        forceUsers[forceSide] = firstSide;                        
                    }

                    forceUsers[forceSide].Add(forceUser);

                    if (currentCommand == "->")
                    {

                    }
                   
                }


                command = Console.ReadLine();
            }
        }
    }
}
