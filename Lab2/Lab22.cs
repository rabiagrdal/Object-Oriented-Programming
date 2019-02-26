using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using wl = System.Console;
namespace Lab22
{
    class Student
    {
        public static List<Student> list = new List<Student>();
        //by default attributes are private
        private int _StudentID;
        private string _Name;
        private string _Gender;

        public void Add(Student s)
        {
            list.Add(s);
        }

        public void Remove(Student s)
        {
            list.Remove(s);
        }
        //properties
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


        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
            }
        }
        public string Gender
        {
            get => _Gender;
            set => _Gender = value;
        }

        public void Display(Student s)
        {
            Console.WriteLine(s.StudentID + " " + s.Name + " " + s.Gender);
        }

        public void Display(List<Student> list)
        {
            foreach (var s in list)
            {
                Console.WriteLine(s.StudentID + " " + s.Name + " " + s.Gender);
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            //Student s = new Student();
            //s.StudentID = 1;
            //s.Name = "Ali";
            //s.Gender = "Male";


            //Student s1 = new Student();
            //s1.StudentID = 2;
            //s1.Name = "Kara";
            //s1.Gender = "Male";

            //List<Student> list = new List<Student>();
            //list.Add(s);
            //list.Add(s1);
            //s.Display(list);

            
            //s.Display(s);


            //Student s = new Student();
            //s.StudentID = 100;
            //s.Name = "KOTO";
            //s.Gender = "Male";

            //Student s1 = new Student();
            //s1.StudentID = 101;
            //s1.Name = "Safa";
            //s1.Gender = "Male";

            //List<Student> stdList = new List<Student>();
            //stdList.Add(s);
            //stdList.Add(s1);

            //foreach (Student st in stdList)
            //{
            //    Console.WriteLine(st.StudentID + " "+
            //        st.Name + " " +
            //        st.Gender);
            //}

            //Console.WriteLine(  s.StudentID + " " +
            //                    s.Name + " "+
            //                    s.Gender);
            //Console.WriteLine(s1.StudentID + " " +
            //                    s1.Name + " " +
            //                    s1.Gender);

            //List<string> NameList = new List<string>();
            //Console.WriteLine("Enter your Name:");
            //string name= Console.ReadLine();
            //NameList.Add(name);

            //for (int i = 0; i < 3; i++)
            //{
            //    NameList.Add(Console.ReadLine());
            //}

            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(40);
            //list.Add(50);


            //foreach (var item in list)
            //{
            //    if (item%2==0 && item%5==0)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}


            Console.ReadLine();
        }
    }
}
