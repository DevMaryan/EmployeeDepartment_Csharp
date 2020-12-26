using System;
using System.Collections.Generic;
using System.Text;


namespace EmployeeDepartment.Models
{
    public class Developer : Employee
    {
        public Developer(string name, string surname, int age, int currentProject, string[] programmingLanguages) : base(name, surname, age) // base gi prakat
        {
            Role = RoleEnum.Developer;
            Salary = 600;
            CurrentProject = currentProject;
            ProgrammingLanguages = programmingLanguages;
        }

        public int YearsOfExperience { get;set; }
        public int CurrentProject { get; set; }
        public string[] ProgrammingLanguages { get; set; }

        public override void GetInfo()
        {
            base.GetSalary(); // base.GetSalay go zemat od employee GetSalary

            Console.WriteLine($"Programming languages knowledge:");
            foreach (var language in ProgrammingLanguages)
            {
                Console.WriteLine($"- {language} ");
            }
        }
    }
}
