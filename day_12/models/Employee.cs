using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_12.models
{
    public class Employee
    {
        public string Name { get; set; }
        public bool IsProbationPassed { get; set; }
        private decimal Salary;

        public void GetIsProbation(decimal salary)
        {
            if (IsProbationPassed)
            {
                Salary = salary;
                Console.WriteLine($"Зарплата сотрудника {Name}: {salary}");
            }
            else
            {
                Console.WriteLine("Сотрудник не прошёл испытательный срок.");
            }
        }
        //
        public decimal GetSalary()
        { 
            return Salary;
            
        }
    }
}
