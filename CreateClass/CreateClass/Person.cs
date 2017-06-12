using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    enum Genders
    {
        Male, Female
    }
    class Person
    {
        private String _name;
        private DateTime _birthDate;
        private Genders _gender;

        public string Name { get => _name; set => _name = value; }
        public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }
        internal Genders Gender { get => _gender; set => _gender = value; }

        public Person()
        {
        }

        public Person(String name, Genders gender)
        {
            this.Name = name;
            this.Gender = gender;
        }

        override
        public String ToString()
        {
            return "name: " + Name + "\nbirthDate: " + BirthDate + "\ngender: " + Gender;
        }
    }
}
