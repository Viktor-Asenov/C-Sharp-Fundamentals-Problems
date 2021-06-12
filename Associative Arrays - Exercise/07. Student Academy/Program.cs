using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var students = new Dictionary<string, List<double>>();
            var studentGrades = new List<double>();

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    studentGrades = new List<double>();
                    students[studentName] = studentGrades;
                }

                students[studentName].Add(grade);
            }

            var filtered = students
                .Where(x => (x.Value.Sum() / x.Value.Count) >= 4.50)
                .OrderByDescending(x => x.Value.Sum() / x.Value.Count)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var student in filtered)
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Sum() / student.Value.Count:f2}");
            }
        }
    }
}
