using System;

namespace _11._Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            char action = char.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            switch (action)
            {
                case '/':
                    Console.WriteLine(GetDivision(firstNum, secondNum));
                    break;
                case '*':
                    Console.WriteLine(GetMultiplying(firstNum, secondNum));
                    break;
                case '+':
                    Console.WriteLine(GetPlusAction(firstNum, secondNum));
                    break;
                case '-':
                    Console.WriteLine(GetMinusAction(firstNum, secondNum));
                    break;
            }
        }

        static int GetDivision(int firstNum, int secondNum)
        {
            return firstNum / secondNum;
        }

        static int GetMultiplying(int firstNum, int secondNum)
        {
            return firstNum * secondNum;
        }

        static int GetPlusAction (int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        static int GetMinusAction(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }
    }
}
