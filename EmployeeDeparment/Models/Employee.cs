using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDepartment.Models
{
    public class Employee
    {
        public Employee(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;

        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public virtual int Salary { get; set; }

        public RoleEnum Role { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Employee {Name} {Surname} is {Age} years old. His salary is ${Salary} and his position is {Role} ");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }

    }
}
