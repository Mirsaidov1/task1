using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_11.models
{
    public class Student : Person
    {
        public int Grade { get; set; }

        public override void Work()
        {
            Console.WriteLine($"Студент учится: {Grade}");
        }
    }
}
