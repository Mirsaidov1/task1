using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11.Abstract
{
    public class WashingMachine : Appliance
    {
        public override void TurnOff()
        {
            Console.WriteLine("Стиральная машина Выключение");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Стиральная машина Включение");
        }
    }
}
