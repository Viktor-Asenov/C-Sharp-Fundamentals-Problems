using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main()
        {
            string action = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int result = 0;

            if (action == "add")
            {
                result = Add(firstNum, secondNum);
            }
            else if (action == "multiply")
            {
               result = Multiply(firstNum, secondNum);
            }
            else if (action == "subtract")
            {
                result = Subtract(firstNum, secondNum);
            }
            else if (action == "divide")
            {
                result = Divide(firstNum, secondNum);
            }

            Console.WriteLine($"{result}");
        }

        static int Add(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        static int Multiply(int firstNum, int secondNum)
        {
            return firstNum * secondNum;
        }

        static int Subtract(int firstNum, int secondNum) 
        {
            return firstNum - secondNum;
        }          

        static int Divide (int firstNum, int secondNum)
        {
            return firstNum / secondNum;
        }
    }
}
