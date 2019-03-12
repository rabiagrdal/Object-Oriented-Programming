using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Model
{
    //abstract keywork does not allow to creaet the object of this class
   public abstract class Person
    {
        // Attributes
        private string name;
        private string gender;
        private string email;
        private string tcKimlik;

        // Properties for Encapsulation
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Email { get => email; set => email = value; }
        public string TcKimlik { get => tcKimlik; set => tcKimlik = value; }
        
        // Constructor
        public Person(string name, string gender, string email, string tcKimlik)
        {
            this.name = name;
            this.gender = gender;
            this.email = email;
            this.tcKimlik = tcKimlik;
        }
    }
}
