using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    internal class Payroll
    {
        private List<Employee> employees { get; set; }

        public Payroll()
        {
            employees = new List<Employee>(); 
        }

        internal void AddEmployee(string name, uint salary)
        {
            employees.Add(new Employee(name, salary)); 
        }
        internal IEnumerable<Employee> GetEmployees()
        {
            return employees.ToArray(); 
        }
    }
}
