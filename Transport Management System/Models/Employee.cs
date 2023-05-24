using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Management_System.Models
{
    internal class Employee
    { 
        private string name;
        private DateTime birthday;
        private int employmentYear;
        private int salary;

        public Employee(string name, DateTime birthday, int employmentYear, int salary)
        {
            this.name = name;
            this.birthday = birthday;
            this.employmentYear = employmentYear;
            this.salary = salary;
        }

        public string Name { get => name; set => name = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public int EmploymentYear { get => employmentYear; set => employmentYear = value; }
        public int Salary { get => salary; set => salary = value; }

        public override string ToString()
        {
            return (Name + "," + Birthday.ToString() + ","
                + EmploymentYear + "," + Salary);
        }
    }
}
