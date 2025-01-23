using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11.models
{
    public class Rectangle : Shape
    {
        private int s = 0;
        private int p = 0;
        public override void CalculateArea()
        {
            int a = 6;    
            int b = 4;
            s = a * b;
            Console.WriteLine($"Площадь прямоугольника: {s}");
        }

        public override void CalculatePerimetr()
        {
            int a = 5;
            int b = 4;
            p = (a + b) * 2;
            Console.WriteLine($"Периметр прямоугольника: {p}");
        }
    }
}
