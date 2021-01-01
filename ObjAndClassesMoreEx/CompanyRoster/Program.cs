using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    class Program
    {
        public class Employees
        {
            public Employees(string name, double salary, string department)
            {
                Name = name;
                Salary = salary;
                Department = department;
            }
            public string Name { get; set; }
            public double Salary { get; set; }
            public string Department { get; set; }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employees> companyRoster = new List<Employees>();
            List<string> deps = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] employeeInfo = Console.ReadLine().Split();
                string name = employeeInfo[0];
                double wage = double.Parse(employeeInfo[1]);
                string department = employeeInfo[2];
                deps.Add(department);
                Employees employee = new Employees(name, wage, department);
                companyRoster.Add(employee);
            }

            deps = deps.Distinct().ToList();
            string bestDep = string.Empty;
            double bestAverageSalary = double.MinValue;

            foreach (var dep in deps)
            {
                double currentAverageSalary = companyRoster.Where(x => x.Department == dep).Select(x => x.Salary).Sum();

                if (currentAverageSalary > bestAverageSalary)
                {
                    bestAverageSalary = currentAverageSalary;
                    bestDep = dep;
                }
            }
            Console.WriteLine("Highest Average Salary: {0}", bestDep);

            foreach (var item in companyRoster.Where(x => x.Department == bestDep).OrderByDescending(x => x.Salary))
            {
                Console.WriteLine("{0} {1:f2}", item.Name, item.Salary);
            }
        }
    }
}
