using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Inheritance
{
    class Employee : Human
    {
        //public Employee(string name, int iD, string gender, int age) : base(name, iD, gender, age)
        //{
        //}

        public string Position { get; set; }
        protected double Salary { get; set; }
        public void SetValve(string name, int id,string gender,int age)
        {
            Name = name;
            ID = id;
            Gender = gender;
            Age = age;
        }
        public void SetValue2()
        {
            Position = "Engineer";
            Salary = 1000;
        }
        public override string ToString()
        {
            return $"{Name}, {ID}, {Gender}, {Age}, {Position}, {Salary}";
        }
    }
}
