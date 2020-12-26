using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDepartment.Models
{
    public class Manager : Employee
    {
        public Manager(string name, string surname, int age) : base(name, surname, age)
        {
            Role = RoleEnum.Manager;
            Salary = 1000;

        }
        public Department Department { get; set; }

        public override double GetSalary()
        {
            return Salary + (Department.GetRevenue() * 0.2);
        }
    }   
}
