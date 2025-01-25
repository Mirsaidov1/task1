using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_13.models
{
    public class Person
    {
        private int age;

        public Person(int age)
        {
            if (age < 0 || age > 120)
            {
                throw new InvalidAgeException("Возраст должен быть между 0 и 120.");
               
            }
            this.age = age;
        }
    }
}
