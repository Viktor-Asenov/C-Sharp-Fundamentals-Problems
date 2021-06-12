using System;

namespace SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmplEfficiency = int.Parse(Console.ReadLine());
            int secondEmplEfficiency = int.Parse(Console.ReadLine());
            int thirdEmplEfficiency = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            int wholeEmplEfficiency = firstEmplEfficiency + secondEmplEfficiency + thirdEmplEfficiency;

            int hoursCount = 0;            

            while (studentsCount > 0 )
            {
                hoursCount++;

                if (hoursCount % 4 == 0)
                {
                    continue;
                }

                studentsCount -= wholeEmplEfficiency;
            }

            Console.WriteLine($"Time needed: {hoursCount}h.");
        }
    }
}
