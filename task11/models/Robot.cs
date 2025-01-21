using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task11.inter;

namespace task11.models
{
    public class Robot : IMovable
    {
        public void Move(int speed)
        {
            Console.WriteLine($"Robot speed: {speed}");
        }
    }
}
