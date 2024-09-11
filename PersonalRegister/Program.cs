namespace PersonalRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Droid d = new Droid("C-3PO", 25000);
            //Console.WriteLine(d.GetFirstName());
            ////d.firstname = "R2-D2";
            //d.SetFirstName("R2-D2"); 
            //Console.WriteLine(d.GetFirstName());
            //d.Salary = 25000;
            //Console.WriteLine(d.Salary);

            //Employee emp = new Employee("Anders", 20000);
            ////emp.Name = "Anders";
            ////emp.Salary = 20000; 
            //Console.WriteLine($"Name:{emp.Name} Salary:{emp.Salary}");
            //emp.Name = "Nisse";
            //Console.WriteLine($"Name:{emp.Name} Salary:{emp.Salary}");

            //Payroll payroll = new Payroll();

            ////Lägger till ny anställd
            //payroll.AddEmployee("Kalle", 25000);
            //payroll.AddEmployee("Anna", 30000);
            ////payroll.AddEmployee("Anna2", 30000);
            ////payroll.AddEmployee("Anna3", 30000);
            ////payroll.AddEmployee("Anna4", 30000);
            ////payroll.AddEmployee("Anna5", 30000);
            ////payroll.AddEmployee("Anna6", 30000);

            ////Hämtar en samling av alla anställda
            //IEnumerable<Employee> employees = payroll.GetEmployees();


            ////Skriver ut alla anställda
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine($"Name:{employee.Name} Salary:{employee.Salary}");
            //}

            //Droid d1 = new Droid();
            //d1.Salary = 00002;
            //Droid d2 = new Droid();
            //d2.Salary = 00052;

            //Console.WriteLine(d1.Salary);
            //Console.WriteLine(d2.Salary);
            //Console.WriteLine(d1.Salary);
            //d1.Count;
            Droid d1 = new Droid();
            Console.WriteLine(Droid.Count);
            Droid d2 = new Droid();
            Droid.GetCount();
            Droid d3 = new Droid();
            Console.WriteLine(Droid.Count);
            Droid d4 = new Droid();
            Droid.GetCount();

        }
    }
}
