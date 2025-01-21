using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11.models
{
    public  class Circle : Shape
    {
        int sum = 0;
        public void CalculateArea(int a, int b)
        {
            sum += a * b;
            Console.WriteLine(sum);
        }
    }
}
