using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDepartment.Models
{
    public class Salesman : Employee
    {

        public Salesman(string name, string surname, int age) : base(name, surname, age) 
        {
            Role = RoleEnum.Sales;
            Salary = 400;

        }
        private double SalesRevenue { get; set; }

        public void AddRevenue(double revenue)
        {
            SalesRevenue += revenue;
        }

        public void DecreaseRevenue(double revenue)
        {
            if (revenue < SalesRevenue)
            {
                SalesRevenue -= revenue;
            }
        }

        public double GetSalesRevenue()
        {
            return SalesRevenue;
        }

        public override double GetSalary()
        {
            return (base.GetSalary()) + (SalesRevenue * 0.1);
        }
    }
    
}
