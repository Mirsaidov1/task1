using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11.models
{
    public  class Circle : Shape
    {
        private double s = 0;
        private double p = 0;
        public override void CalculateArea()
        {

            double r = 3.2;
            s = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Площадь круга: {s}");
            
        }

        public override void CalculatePerimetr()
        {

            double r = 4.2;
            p = 2 * Math.PI * r;
            Console.WriteLine($"Периметр круга: {p}");
        }
    }
}
