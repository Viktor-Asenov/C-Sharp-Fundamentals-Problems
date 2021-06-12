using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleForElevating = int.Parse(Console.ReadLine());
            int capacityElevator = int.Parse(Console.ReadLine());

            int courses = 0;

            while (peopleForElevating > 0)
            {
                if (peopleForElevating < capacityElevator)
                {
                    courses++;
                    break;
                }

                peopleForElevating -= capacityElevator;
                courses++;
            }

            Console.WriteLine(courses);
        }
    }
}
