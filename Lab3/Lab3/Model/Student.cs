using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Model
{
   public class Student
    {
        //attributes
        private int _StudentID;
        private string _Name;
        private string _Gender;
        private string _DateOfBirth;

    // Properties (Encapsulation)
        public int StudentID
        {
            get
            {
                return _StudentID;
            }
            set
            {
                _StudentID = value;
            }
        }
        public string Name { get => _Name; set => _Name = value; }
        public string Gender { get => _Gender; set => _Gender = value; }
        public string DateOfBirth { get => _DateOfBirth; set => _DateOfBirth = value; }

        public Student(int stID,string name, string gender, string dob )
        {
            _StudentID = stID;
            _Name = name;
            _Gender = gender;
            _DateOfBirth = dob;
        }
        // overloaded constructor
        public Student(Student s)
        {
            _StudentID = s.StudentID;
            _Name = s.Name;
            _Gender = s.Gender;
            _DateOfBirth = s.DateOfBirth;
        }

    }
}
