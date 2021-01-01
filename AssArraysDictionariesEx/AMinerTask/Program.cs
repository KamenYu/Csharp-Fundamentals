using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            Dictionary<string, int> miningLog = new Dictionary<string, int>();

            while(resource != "stop")
            {
                int q = int.Parse(Console.ReadLine());
                
                if (miningLog.ContainsKey(resource) == false)
                {
                    miningLog.Add(resource, 0);
                }
                miningLog[resource] += q;

                resource = Console.ReadLine();
            }

            foreach (var item in miningLog)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }           
        }
    }
}
