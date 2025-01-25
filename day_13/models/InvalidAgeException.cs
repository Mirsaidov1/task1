using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_13.models
{
    public class InvalidAgeException: Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
           
        }
    
    }
}
