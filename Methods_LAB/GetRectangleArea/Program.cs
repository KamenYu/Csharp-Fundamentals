using System;

namespace GetRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double area = RectangleArea(length, width);
            Console.WriteLine(area);
        }

        static double RectangleArea(double length, double width)
        {
            return length * width;
        }
    }
}
