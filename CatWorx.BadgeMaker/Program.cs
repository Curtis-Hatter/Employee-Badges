using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static List<Employee> GetEmployess()
        {
            //I will retrun a List of Strings
            List<Employee> employees = new List<Employee>();
            while (true)
            {
                Console.WriteLine("Please enter the first name (leave empty to exit): ");
                string firstName = Console.ReadLine();
                if (firstName == "")
                {
                    break;
                };

                // Add a Console.ReadLine() for each value
                Console.WriteLine("Please enter the last name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Please enter the ID: ");
                int id = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Photo URL: ");
                string photoUrl = Console.ReadLine();

                // Create a new Emplyee instance
                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                employees.Add(currentEmployee);
            }
            return employees;
        }

        static void Main(string[] args)
        {
            // This is our employee-getting code now
            List<Employee> employees = new List<Employee>();

            employees = GetEmployess();

            Util.MakeCSV(employees);
            Util.MakeBadges(employees);
        }
    }
}
