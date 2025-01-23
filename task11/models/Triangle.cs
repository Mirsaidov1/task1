using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11.models
{
    public class Triangle : Shape
    {
        private double s = 0;
        private double p = 0;
        public override void CalculateArea()
        {
            int a = 10;
            int b = 10;
            int c = 10;

            int p = 12;

            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine($"Площадь треугольника: {s}");
        }

        public override void CalculatePerimetr()
        {
            int a = 2;
            int b = 4;
            int c = 6;

            p = a + b + c;
            Console.WriteLine($"периметр треугольника: {p}");
        }
    }
}
