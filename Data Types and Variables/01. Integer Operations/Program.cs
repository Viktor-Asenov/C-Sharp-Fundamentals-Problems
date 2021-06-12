using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            int numFour = int.Parse(Console.ReadLine());

            int resultFirstSecond = numOne + numTwo;
            decimal division = resultFirstSecond / numThree;
            decimal finalResult = division * numFour;

            Console.WriteLine(finalResult);
        }
    }
}
