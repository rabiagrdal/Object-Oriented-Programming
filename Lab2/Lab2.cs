using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21
{
    class Student
    {
       public List<Student> list;

       private int _StudentID;
       private string _Name;
       private string _Gender;

        // properties
        public int StudentID {
            get
            {
                return _StudentID;
            }
            set
            {
                if (value<0)
                {
                    throw new Exception("Invalid studentID");
                }
                _StudentID = value;
            }
        }



        public string Name { get => _Name; set => _Name = value; }
        public string Gender { get => _Gender; set => _Gender = value; }



        //public void Display(Student s)
        //{
        //    Console.WriteLine(s.StudentID + " " +s.Name + " " + s.Gender);
        //}


        public void Display(List<Student> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(
                    list[i].StudentID+ " "+
                    list[i].Name + " " + 
                    list[i].Gender);
            }
        }

        public void Add(Student s)
        {

        }
    }
  
    class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student();
            //s1.StudentID = 101;
            s1.Name = "Ali";
            s1.Gender = "Male";

            // ask user to add studentID, name, Gender

             int id = int.Parse( Console.ReadLine()); 

            //Student s1 = new Student();
            //s1.StudentID = 1;
            //s1.Name = "Ali";
            //s1.Gender = "Male";

            //Student s2 = new Student();
            //s2.StudentID = 2;
            //s2.Name = "Hande";
            //s2.Gender = "Female";

            //List<Student> l = new List<Student>();
            //l.Add(s1);
            //l.Add(s2);
            //s1.Display(l);

            //s1.Display(s1);
            //s2.Display(s2);

            //Console.WriteLine(
            //    s1.StudentID + " "+
            //    s1.Name + " "+
            //    s1.Gender);

            //Console.WriteLine(
            //    s2.StudentID + " " +
            //    s2.Name + " " +
            //    s2.Gender);

            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(20);
            //list.Add(10);
            //list.Add(29);
            //list.Add(11);
            //list.Add(15);

            ////Console.WriteLine(list.Count);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadLine();
        }
    }
}
