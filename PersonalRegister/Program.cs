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

                MenuHelpers.ShowMainMenu();

                string input = Console.ReadLine().ToUpper();

                switch (input)
                {
                    case MenuHelpers.Add:
                        AddEmployee();
                        break;
                    case MenuHelpers.Print:
                        PrintEmployees();
                        break;
                    case MenuHelpers.Quit:
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

            //Employee employee = new Employee(name, salary);

            //payroll.AddEmployee(name, salary);
            payroll.AddEmployee(new Employee(name, salary));
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
