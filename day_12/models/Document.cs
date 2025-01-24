using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_12.models
{
    public abstract class Document
    {
        public abstract void Print();

        public void Save()
        {
            Console.WriteLine("Document saved");
        }
    }
}
