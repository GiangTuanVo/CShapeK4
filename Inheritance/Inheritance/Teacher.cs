using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Inheritance
{
    class Teacher : Employee
    {
        public string Branch { get; set; }
        public void FindSalary()
        {
            Salary = 2000;
        }
        public void SetPosition()
        {
            Position = "Teacher";
            Branch = "Math";
        }

        public override string ToString()
        {
            return $"{Name}, {ID}, {Gender}, {Age}, {Position}, {Salary},{Branch}";
        }
    }
}
