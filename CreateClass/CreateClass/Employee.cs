using System;


namespace CreateClass
{
    class Employee : Person, ICloneable
    {
        private int _salary;
        private String _profession;

        public String Profession
        {
            get { return _profession; }
            set { _profession = value; }
        }

        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public Employee(String name, DateTime birthDate, int salary, String profession)
        {
            this.Name = name;
            this.BirthDate = birthDate;
            this.Salary = salary;
            this.Profession = profession;
        }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            return this.MemberwiseClone();
        }

        override
        public String ToString()
        {
            base.ToString();
            return "salary: " + Salary + "\nprofession: " + Profession;
        }
    }
}
