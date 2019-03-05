using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Model;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(101, "Ali", "Male", "10-12-2001");
            Student s2 = new Student(102, "Anila", "Female", "10-12-2001");


            /*
            Student std = new Student();
            std.StudentID = 100;
            std.Name = "Ali";
            std.DateOfBirth = "12-03-2000";
            std.Gender = "Male";

            Student st = new Student(std);
            */
        }
    }
}
