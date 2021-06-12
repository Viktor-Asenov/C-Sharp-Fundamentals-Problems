using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            var courses = new Dictionary<string, List<string>>();
            var students = new List<string>();

            while (command != "end")
            {
                string[] input = command.Split(" : ").ToArray();

                string courseName = input[0];
                string studentName = input[1];

                if (!courses.ContainsKey(courseName))
                {
                    students = new List<string>();
                    courses[courseName] = students;                    
                }

                courses[courseName].Add(studentName);

                command = Console.ReadLine();
            }

            var sortedCourses = courses.OrderByDescending(x => x.Value.Count).ToDictionary(x => x.Key, x => x.Value);
            

            foreach (var course in sortedCourses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var student in course.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
