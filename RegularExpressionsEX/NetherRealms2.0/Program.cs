using System.Linq;
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace NetherRealms2._0
{
    public class Demon
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public double ATK { get; set; }

        public override string ToString()
        {
            return $"{Name} - {HP} health, {ATK:f2} damage";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Demon> allD = new List<Demon>();
            Regex numbers = new Regex(@"[+-]?\d+\.?\d*");

            string[] demonInfo = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var demon in demonInfo)
            {
                string filter = "0123456789-+*/.";
                int hp = demon.Where(c => !filter.Contains(c)).Sum(c =>c);

                double damage = CalculateATK(numbers, demon);
                allD.Add(new Demon() { Name = demon, HP = hp, ATK = damage });
            }

            foreach (var item in allD.OrderBy(x =>x.Name))
            {
                Console.WriteLine(item);
            }
        }

        private static double CalculateATK(Regex numbers, string demon)
        {
            MatchCollection atkEl = numbers.Matches(demon);
            double damage = 0;
            foreach (Match item in atkEl)
            {
                damage += double.Parse(item.Value);
            }

            foreach (var ch in demon)
            {
                if (ch == '*')
                {
                    damage *= 2;
                }
                else if(ch == '/')
                {
                    damage /= 2;
                }
            }
            return damage;
        }
    }
}
