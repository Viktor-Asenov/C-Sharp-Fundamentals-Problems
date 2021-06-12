using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] currentPersonData = command.Split();

                string name = currentPersonData[0];
                string personID = currentPersonData[1];
                int age = int.Parse(currentPersonData[2]);

                var person = new Person
                {
                    Name = name,
                    PersonID = personID,
                    Age = age
                };

                people.Add(person);

                command = Console.ReadLine();
            }

            var orderedPeople = people.OrderBy(x => x.Age);

            foreach (var person in orderedPeople)
            {
                Console.WriteLine($"{person.Name} with ID: {person.PersonID} is {person.Age} years old.");
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string PersonID { get; set; }
        public int Age { get; set; }
    }
}
