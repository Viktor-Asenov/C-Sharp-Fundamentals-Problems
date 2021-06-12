using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            int countStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < countStudents; i++)
            {
                string[] currentStudent = Console.ReadLine().Split();

                var student = new Student
                {
                    FirstName = currentStudent[0],
                    LastName = currentStudent[1],
                    Grade = double.Parse(currentStudent[2])
                };

                students.Add(student);
            }

            var orderedStudentsByGrade = students.OrderByDescending(x => x.Grade);

            foreach ( var student in orderedStudentsByGrade)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}
