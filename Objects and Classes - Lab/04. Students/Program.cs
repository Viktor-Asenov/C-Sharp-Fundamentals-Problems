using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] currentInput = command.Split().ToArray();

                string first = currentInput[0];
                string last = currentInput[1];
                int age = int.Parse(currentInput[2]);
                string homeCity = currentInput[3];

                Student student = new Student();

                student.FirstName = first;
                student.LastName = last;
                student.Age = age;
                student.Hometown = homeCity;
              
                students.Add(student);
                command = Console.ReadLine();
            }

            string cityName = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.Hometown == cityName)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }            
        }
        class Student
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public int Age { get; set; }

            public string Hometown { get; set; }

        }        
    }
}
