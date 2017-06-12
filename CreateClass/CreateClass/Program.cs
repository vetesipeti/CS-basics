using System;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Kovacs = new Employee("Géza", DateTime.Now, 1000, "léhűtő");
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Console.WriteLine("Kovacs: " + Kovacs.ToString());
            Console.WriteLine("Kovacs2: " + Kovacs2.ToString());
            Console.ReadKey();
        }
    }
}