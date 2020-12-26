using System;
using System.Collections.Generic;
using System.Text;


namespace EmployeeDepartment.Models
{
    public class Department
    {
        public Developer[] Developers { get; set; }

        public Salesman[] Salesmen { get; set; }

        public double GetRevenue()
        {
            double sum = 0.0;

            if (Salesmen != null)
            {
                for (int i = 0; i < Salesmen.Length; i++)
                {
                    sum += Salesmen[i].GetSalesRevenue();
                }
            }

            return sum;
        }

        public void GetSkillset()
        {
            if (Developers == null)
            {
                Console.WriteLine("There arent any Developers in this Department mate!");
            }
            else
            {
                for (int j = 0; j < Developers.Length; j++)
                {
                    Console.WriteLine($"The Developer No. {j + 1} knows the following programming languages:");
                    Console.WriteLine(string.Join(",", Developers[j].ProgrammingLanguages));
                }
            }
        }
    }

}
