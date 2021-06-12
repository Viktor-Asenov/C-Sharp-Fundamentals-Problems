using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var companies = new Dictionary<string, List<string>>();
            var idList = new List<string>();

            while (input != "End")
            {
                string[] currentData = input.Split("-> ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string companyName = currentData[0];
                string employeeID = currentData[1];

                if (!companies.ContainsKey(companyName))
                {
                    idList = new List<string>();
                    companies[companyName] = idList;
                }

                if (!companies[companyName].Contains(employeeID))
                {
                    companies[companyName].Add(employeeID);
                }
                
                input = Console.ReadLine();
            }

            var sortedCompanies = companies.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var company in sortedCompanies)
            {
                Console.WriteLine($"{company.Key}");

                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
