using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    internal class Droid
    {
        //Field, privat, kommer inte åt utanför klassen. Liten bokstav
        private string firstname;

        private int salary; 


        //Property, publik, går att komma åt utanför klassen, stor bokstav
        public int Salary
        {
            get { return salary; }
            set
            {
                if(value < 0)
                {
                    salary = 0;
                }
                else
                {
                    salary = value;
                }
            }

        }

        //Auto property
        public int Salary2 { get; set; }

        //private int salary2;
        //public int Salary2
        //{
        //    get { return salary2; }
        //    set { salary2 = value; }
        //}

        
        public Droid(string name, int salary)
        {
            firstname = name;
            Salary = salary; 
        }
        public Droid()
        {
            
        }

        public string GetFirstName()
        {
            return firstname; 
        }
        public void SetFirstName(string name)
        {
            firstname = name;
        }
    }
}
