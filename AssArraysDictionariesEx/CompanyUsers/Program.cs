using System;
using System.Linq;
using System.Collections.Generic;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" -> ");
            Dictionary<string, List<string>> companyInfo = new Dictionary<string, List<string>>();

            while (input[0] != "End")
            {
                string companyName = input[0];
                string employeeID = input[1];

                if(companyInfo.ContainsKey(companyName) == false)
                {                    
                    companyInfo.Add(companyName, new List<string>());
                    companyInfo[companyName].Add(employeeID);
                }
                else
                {
                    if (companyInfo[companyName].Contains(employeeID) == false)
                    {
                        companyInfo[companyName].Add(employeeID);
                    }
                }

                input = Console.ReadLine().Split(" -> ");
            }          

            foreach (var item in companyInfo.OrderBy(x =>x.Key))
            {
                Console.WriteLine($"{item.Key}");

                foreach (var ID in item.Value)
                {
                    Console.WriteLine($"-- {ID}");
                }
            }
        }
    }
}
