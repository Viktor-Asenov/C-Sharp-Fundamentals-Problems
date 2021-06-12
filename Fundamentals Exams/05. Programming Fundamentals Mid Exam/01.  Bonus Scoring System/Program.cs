using System;

namespace _01.__Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            double studentsCount = double.Parse(Console.ReadLine());
            double lecturesCount = double.Parse(Console.ReadLine());
            double initialBonus = double.Parse(Console.ReadLine());

            double maxBonus = double.MinValue;
            double maxAttendances = double.MinValue;

            for (int i = 0; i < studentsCount; i++)
            {
                double attendancesCurrentStudent = double.Parse(Console.ReadLine());                
                double totalBonusCurrentStudent = attendancesCurrentStudent / lecturesCount * (5 + initialBonus);

                if (totalBonusCurrentStudent > maxBonus)
                {
                    maxBonus = totalBonusCurrentStudent;
                    maxAttendances = attendancesCurrentStudent;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Round(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendances} lectures.");
        }
    }
}
