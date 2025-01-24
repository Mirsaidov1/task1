using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_12.models
{
    public class PdfDocument : Document
    {

        public override void Print()
        {
            Console.WriteLine("Printing PDF document");
        }
    }
}
