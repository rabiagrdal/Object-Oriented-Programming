using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Model
{
   public class Student
    {
        // Attributes
        private int _StudentID;
        private string _FirstName;
        private string _LastName;
        private string _Gender;
        private string _DateOfBirth;
        private string _MobileNumber;
        private string _FatherName;
        private string _Address;
        private string _TCKilim;
        private string _Email;
        private string _Password;
        private int _DepartmentID;
        private int _CountryID;

        //constructor
        public Student(int StudentID, 
            string FirstName, string LastName, string Gender, 
            string DateOfBirth, string MobileNumber, 
            string FatherName, string Address, string TCKilim, 
            string Email, string Password, int DepartmentID, int CountryID)
        {
            _StudentID = StudentID;
            _FirstName = FirstName;
            _LastName = LastName;
            _Gender = Gender;
            _DateOfBirth = DateOfBirth;
            _MobileNumber = MobileNumber;
            _FatherName = FatherName;
            _Address = Address;
            _TCKilim = TCKilim;
            _Email = Email;
            _Password = Password;
            _DepartmentID = DepartmentID;
            _CountryID = CountryID;
        }

        // properties
        public int StudentID { get => _StudentID; set => _StudentID = value; }
        public string FirstName { get => _FirstName; set => _FirstName = value; }
        public string LastName { get => _LastName; set => _LastName = value; }
        public string Gender { get => _Gender; set => _Gender = value; }
        public string DateOfBirth { get => _DateOfBirth; set => _DateOfBirth = value; }
        public string MobileNumber { get => _MobileNumber; set => _MobileNumber = value; }
        public string FatherName { get => _FatherName; set => _FatherName = value; }
        public string Address { get => _Address; set => _Address = value; }
        public string TCKilim { get => _TCKilim; set => _TCKilim = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Password { get => _Password; set => _Password = value; }
        public int DepartmentID { get => _DepartmentID; set => _DepartmentID = value; }
        public int CountryID { get => _CountryID; set => _CountryID = value; }


        // Methods

        public void Login(string email, string password)
        {

        }

        public void Logout()
        {

        }
   }
}
