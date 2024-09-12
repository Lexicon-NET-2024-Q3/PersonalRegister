using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    internal class Employee
    {
        public string Name { get; set; }
        public uint Salary { get; set; }

        public SalaryLevel SalaryLevel
        {
            get
            {
                if (Salary < 25000)
                    return SalaryLevel.Junior;
                else
                    return SalaryLevel.Senior; 
            }
        }


        public Employee(string name, uint salary)
        {
            Name = name;
            Salary = salary; 
        }

        public override string ToString()
        {
            return $"Name: {Name} Salary: {Salary} Salary Level: {SalaryLevel}"; 
        }
    }
}
