using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge2
{
    class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        //default constructor
        public Employee()
        {
            Name = "Mantas";
            FirstName = "Masalis";
            Salary = 50000;
        }

        public void Work()
        {
            Console.WriteLine("I am working");
        }

        public void Pause()
        {
            Console.WriteLine("I am Having a break");
        }
    }
}
