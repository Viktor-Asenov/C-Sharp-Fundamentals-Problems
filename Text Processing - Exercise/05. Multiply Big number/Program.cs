using System;
using System.Numerics;

namespace _05._Multiply_Big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstNum = BigInteger.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            BigInteger sum = firstNum * secondNum;

            Console.WriteLine(sum);
        }
    }
}
