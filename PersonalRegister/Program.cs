using System.ComponentModel;
using PersonalRegister.Helpers;

namespace PersonalRegister
{
    internal class Program
    {
        private static Payroll payroll = new Payroll(); 
        static void Main(string[] args)
        {
            bool isAlive = true;
            SeedData(); 
            do
            {
                Console.WriteLine("1: Add employee" +
                    "\n2: Show employees" +
                    "\nQ: Quit");

                string input = Console.ReadLine().ToUpper();

                switch (input)
                {
                    case "1":
                        AddEmployee();
                        break;
                    case "2":
                        PrintEmployees();
                        break;
                    case "Q":
                        isAlive = false; 
                        break;
                    default:
                        break;
                }

            } while (isAlive);
        }       

        private static void AddEmployee()
        {
            string name = Util.AskForString("Name");
            uint salary = Util.AskForUInt("Salary");            

            payroll.AddEmployee(name, salary); 
        }
        private static void PrintEmployees()
        {
            IEnumerable<Employee> employees = payroll.GetEmployees();

            foreach(Employee employee in employees)
            {
                //Console.WriteLine($"Name: {employee.Name} Salary: {employee.Salary}");
                Console.WriteLine(employee); 
            }
        }

        private static void SeedData()
        {
            payroll.AddEmployee("Kalle", 25000);
            payroll.AddEmployee("Anna", 28000);
            payroll.AddEmployee("Stefan", 35000);
        }
    }
}
