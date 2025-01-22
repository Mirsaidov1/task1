using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace task11.models
{
    public class Cat : Animal
    {
        public void Sound()
        {
            Console.WriteLine("my my my");
        }

        public override void Sleep()
        {
            Console.WriteLine("Cat sleep");
        }
    }
}
