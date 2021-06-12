using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine().Split('!').ToList();

            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string [] input = command.Split();
                string item = input[1];                

                if (input[0] == "Urgent")
                {                    
                    AddItem(shoppingList, input, item);
                }
                else if (input[0] == "Unnecessary")
                {
                    RemoveItem(shoppingList, input, item);
                }
                else if (input[0] == "Correct")
                {
                    string oldItem = string.Empty;
                    string newItem = string.Empty;

                    RemoveAt(shoppingList, input, oldItem, newItem);
                }
                else if (input[0] == "Rearrange")
                {
                    Rearange(shoppingList, input, item);
                }


                command = Console.ReadLine();
            }

            for (int i = 0; i < shoppingList.Count; i++)
            {
                if (i == shoppingList.Count - 1)
                {
                    Console.Write(shoppingList[i] + " ");
                }
                else
                {
                    Console.Write(shoppingList[i] + "," + " ");
                }                
            }
        }

        static List<string> AddItem (List<string> shoppingList, string[] input, string item)
        {
            item = input[1];

            if (shoppingList.Contains(item))
            {

            }
            else
            {
                shoppingList.Insert(0, item);
            }

            return shoppingList;
        }

        static List<string> RemoveItem (List<string> shoppingList, string[] input, string item)
        {
            item = input[1];

            if (shoppingList.Contains(item))
            {
                shoppingList.Remove(item);
            }
            else
            {

            }

            return shoppingList;
        }

        static List<string> RemoveAt (List<string> shoppingList, string[] input, string oldItem, string newItem)
        {
            oldItem = input[1];
            newItem = input[2];

            if (shoppingList.Contains(oldItem))
            {
                shoppingList.Insert(shoppingList.IndexOf(oldItem), newItem);
                shoppingList.Remove(oldItem);
            }
            else
            {

            }

            return shoppingList;
        }

        static List<string> Rearange (List<string> shoppingList, string[] input, string item)
        {
            item = input[1];

            if (shoppingList.Contains(item))
            {
                shoppingList.Remove(item);
                shoppingList.Add(item);
            }

            return shoppingList;
        }
     }
}
