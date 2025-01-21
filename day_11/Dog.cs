using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_11
{
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking");
        }

        public override void Speak()
        {
            Console.WriteLine("Dog barks");
        }
    }
}
