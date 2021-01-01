using System;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // waaaay too mathematical
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            FindLongerAndPrint(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        private static void FindLongerAndPrint(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double dist1 = Distance(x1, y1);
            double dist2 = Distance(x2, y2);
            double dist3 = Distance(x3, y3);
            double dist4 = Distance(x4, y4);
            double lengthOne = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)); // like pithagorean theorem, but WHY???
            double lengthTwo = Math.Sqrt(Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2));

            if (lengthOne >= lengthTwo)
            {
                if (dist1 <= dist2)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if (dist3 <= dist4)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }

        static double Distance(double x, double y)
        {
            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return distance;
        }
    }
}
