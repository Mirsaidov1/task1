using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_11.models
{
    public class Teacher : Person
    {
        public string Subject { get; set; }

        public override void Work()
        {
            Console.WriteLine($"Учитель преподаёт предмет: {Subject}");
        }
    }
}
