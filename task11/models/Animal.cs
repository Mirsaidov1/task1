using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace task11.models
{
    public class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Animal is eating");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("Animal sleep");
        }
    }
}
