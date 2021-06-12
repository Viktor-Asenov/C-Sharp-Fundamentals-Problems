using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            

            CheckLenght(input);
        }

        static void CheckLenght (string input)
        {       
            if (input.Length < 6 || input.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }            
        }

        static void CheckDigits (string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                
            }
        }

        
    }
}
