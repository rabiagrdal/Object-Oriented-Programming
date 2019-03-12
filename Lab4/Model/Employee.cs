using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Model
{
   public class Employee: Person
    {
        // attribute
        private int employeeID;
        private double salary;

        // properties
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public double Salary { get => salary; set => salary = value; }

        // Constructor
        public Employee(int employeeID, double salary, string name, string gender, string email, string tcKimlik)
            :base(name,gender,email,tcKimlik)
        {
            this.employeeID = employeeID;
            this.salary = salary;
        }
    }
}
