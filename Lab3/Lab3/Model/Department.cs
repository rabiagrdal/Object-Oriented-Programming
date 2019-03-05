using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Model
{
   public class Department
    {
        private int _DepartmentID;
        private string _Name;

        public Department(int DepartmentID, string Name)
        {
            this.DepartmentID = DepartmentID;
            this.Name = Name;
        }

        public int DepartmentID { get => _DepartmentID; set => _DepartmentID = value; }
        public string Name { get => _Name; set => _Name = value; }

        public int Add(Department d)
        {

        }

        public int Delete(int id)
        {

        }
        public int Update(Department d)
        {

        }
        public List<Department> ShowDepartments()
        {

        }

        public Department SearchByID(int id)
        {

        }
        public List<Department> SearchByName(string name)
        {

        }
        public bool CheckDepartmentExists(string name)
        {

        }
    }
}
