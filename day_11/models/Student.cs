using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_11.models
{
    public class Student : Person, IPrintable
    {
        public int Grade { get; set; }

        public override void Work()
        {
            Console.WriteLine($"Студент учится: {Grade}");
        }

        public void PrintInfo() 
        {
            Console.WriteLine($"Студент {Name}, Возраст: {Age} учится: {Grade}");
        }
    }
}
