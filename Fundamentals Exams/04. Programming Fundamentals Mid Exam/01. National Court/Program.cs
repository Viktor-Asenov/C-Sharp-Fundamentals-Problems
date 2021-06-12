using System;

namespace _01._National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeEficiency = int.Parse(Console.ReadLine());
            int secondEmployeEficiency = int.Parse(Console.ReadLine());
            int thirdEmployeEficiency = int.Parse(Console.ReadLine());
            int totalPeople = int.Parse(Console.ReadLine());

            int allEmployesEficiency = firstEmployeEficiency + secondEmployeEficiency + thirdEmployeEficiency;
            int hoursCount = 0;            
            int sumHours = 0;

            while (totalPeople >= allEmployesEficiency )
            {
                if (hoursCount == 3)
                {
                    hoursCount++;
                    sumHours += hoursCount;
                    hoursCount = 0;
                    
                }
                else
                {
                    totalPeople -= allEmployesEficiency;
                    hoursCount++;                    
                }

                if (totalPeople <= allEmployesEficiency)
                {
                    if (hoursCount == 3)
                    {
                        hoursCount++;
                        sumHours += hoursCount;
                        hoursCount = 0;
                    }

                    hoursCount++;
                    sumHours += hoursCount;
                    break;
                }
            }           
            

            Console.WriteLine($"Time needed: {sumHours}h.");
        }
    }
}
