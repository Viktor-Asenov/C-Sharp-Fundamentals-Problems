using System;

namespace _01.__Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            printSignOfInteger();
        }

        static void printSignOfInteger ()
        {
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {n} is zero.");
            }
        }
    }
}
