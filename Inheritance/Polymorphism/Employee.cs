using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Polymorphism
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public double EmployeeSalary { get; set; }
        
        public void SetValves(int id)
        {
            EmployeeID = id;
        }
        public void SetValves(int id,string EmployeeName)
        {
            EmployeeID = id;
            Name = EmployeeName;
        }
        public void SetValves(int id, string EmployeeName,double Salary)
        {
            EmployeeID = id;
            Name = EmployeeName;
            EmployeeSalary = Salary;
        }
    }
}
