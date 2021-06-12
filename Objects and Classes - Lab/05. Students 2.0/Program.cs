using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students_2._0
{
    class Program
    {
        static void Main(string[] args)
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

                if (IsStudentExisting(students, first, last))
                {
                    Student student = GetStudent(students, first, last);

                    student.FirstName = first;
                    student.LastName = last;
                    student.Age = age;
                    student.Hometown = homeCity;
                }
                else
                {
                    Student student = new Student()
                    {
                        FirstName = first,
                        LastName = last,
                        Age = age,
                        Hometown = homeCity
                    };                    

                    students.Add(student);
                }
                
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

        static bool IsStudentExisting(List<Student> students, string first, string last)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == first && student.LastName == last)
                {
                    return true;
                }
            }

            return false;
        }

        static Student GetStudent (List<Student> students, string first, string last)
        {
            Student existingStudent = null;

            foreach (Student student in students)
            {
                if (student.FirstName == first && student.LastName == last)
                {
                    existingStudent = student;
                }
            }

            return existingStudent;
        }
    }    
}

