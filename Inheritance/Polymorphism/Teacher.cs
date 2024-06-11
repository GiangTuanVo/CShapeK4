using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Polymorphism
{
    class Teacher : Employee
    {
        public string EmployeePosition { get; set; }
        public void SetValves(int id, string EmployeeName, double Salary, string position)
        {
            EmployeeID = id;
            Name = EmployeeName;
            EmployeeSalary = Salary;
            EmployeePosition = position;
        }
        public string GetValues()
        {
            string text = $"Employee ID : {EmployeeID}\r\n";
            text += $"Employee Name: {Name}\r\n";
            text += $"Employee Salary {EmployeeSalary}\r\n";
            text += $"Employee Position: {EmployeePosition}";
            return text;
        }
    }
}
