using System;

namespace _08.__Factorial_Division
{
    class Program
    {
        static double GetFactorialFirstNum (double firstNum, double factorialFirstNum)
        {

            for (int i = (int) firstNum; i > 0; i--)
            {
                factorialFirstNum *= i;
            }            

            return factorialFirstNum;
        }

        static double GetFactorialSecondNum (double secondNum, double factorialSecondNum)
        {
            for (int j = (int) secondNum; j > 0; j--)
            {
                factorialSecondNum *= j;
            }

            return factorialSecondNum;
        }

        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            double factorialFirstNum = 1;
            double factorialSecondNum = 1;

            GetFactorialFirstNum(firstNum, factorialFirstNum);
            GetFactorialSecondNum(secondNum, factorialSecondNum);

            double result = factorialFirstNum / factorialSecondNum;

            Console.WriteLine($"{GetFactorialFirstNum(firstNum, factorialFirstNum) / GetFactorialSecondNum(secondNum, factorialSecondNum):f2}");

        }        
    }
}
