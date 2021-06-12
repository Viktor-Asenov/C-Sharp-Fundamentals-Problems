using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var users = new Dictionary<string, User>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string command = input[0];                

                if (command == "register")
                {
                    string userName = input[1];
                    string licensePlateNumber = input[2];

                    if (!users.ContainsKey(userName))
                    {
                        users[userName] = new User
                        {
                            Name = userName,
                            LicenseNumber = licensePlateNumber
                        };

                        Console.WriteLine($"{users[userName].Name} registered {users[userName].LicenseNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {users[userName].LicenseNumber}");
                    }
                }
                else
                {
                    string userName = input[1];                    

                    if (!users.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        users.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                }
                
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Value.Name} => {user.Value.LicenseNumber}");
            }
        }
    }

    class User
    {
        public string Name { get; set; }

        public string LicenseNumber { get; set; }
    }
}
