using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace day_11.models
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"Студент {Name}, Возраст {Age}");
        }

        public virtual void Work()
        {
            Console.WriteLine("Person");
        }

    }
}
