using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Model
{
   public class Student:Person
    {
        //attributes
        private int studentId;
        private string studentType;
        // Properties  getter/setters
        public int StudentId { get => studentId; set => studentId = value; }
        public string StudentType { get => studentType; set => studentType = value; }
        // Constructor
        public Student(int studentId, string name, string gender, string email, string tcKimlik, string studentType)
            :base(name,gender,email,tcKimlik)
        {
            this.StudentId = studentId;
            this.StudentType = studentType;
        }
    }
}
