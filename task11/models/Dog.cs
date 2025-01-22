using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11.models
{
    public class Dog : Animal
    {
        public override void Sleep()
        {
            Console.WriteLine("Dog sleep");
        }
        public void Bark()
        {
            Console.WriteLine("Dog is barking");
        }

    }
}
