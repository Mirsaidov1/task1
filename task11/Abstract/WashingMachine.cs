using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11.Abstract
{
    public abstract class WashingMachine : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("Включение");
        }
    }
}
