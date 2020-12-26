using System;
using EmployeeDepartment.Models;

namespace EmployeeDepartment
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create 2 Departments with 3 Developers and 3 Salesman each

            // 2 Departments
            var department1 = new Department();
            var department2 = new Department();

            // 2 Developers
            var programmingLanguages = new string[] { "C#", "JavaScript", "HTML" };
            var programmingLanguages2 = new string[] { "C#", "JavaScript", "Python", "C++" };

            var developer1 = new Developer("John", "Doe", 26, 5, programmingLanguages);
            developer1.Role = RoleEnum.Developer;
            var developer2 = new Developer("Mike", "Smith", 32, 3, programmingLanguages2);
            developer2.Role = RoleEnum.Developer;

            Console.WriteLine("");
            Console.WriteLine($"The first employee is {developer1.Name} {developer1.Surname}. \nHe is {developer1.Age} years old. \nHis position is {developer1.Role}.\nHe is working on {developer1.CurrentProject} projects. \nHis salary is ${developer1.Salary}.");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"The second employee is {developer2.Name} {developer2.Surname}. \nHe is {developer2.Age} years old. \nHis position is {developer2.Role}.\nHe is working on {developer2.CurrentProject} projects. \nHis salary is ${developer2.Salary}.");
            Console.WriteLine("");

            // 3 Salesman
            var salesman1 = new Salesman("Albert", "Einstien", 35);
            salesman1.Role = RoleEnum.Sales;
            var salesman2 = new Salesman("Julia", "Mannheim", 27);
            salesman2.Role = RoleEnum.Sales;
            var salesman3 = new Salesman("Ana", "Robertson", 28);
            salesman3.Role = RoleEnum.Sales;

            salesman1.AddRevenue(100.00);
            salesman2.AddRevenue(350.00);
            salesman3.AddRevenue(510.00);

            Console.WriteLine("");
            Console.WriteLine($"The third employee is {salesman1.Name} {salesman1.Surname}. \nHe is {salesman1.Age} years old. \nHis position is {salesman1.Role}.\nHis salary is ${salesman1.Salary}.");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"The third employee is {salesman2.Name} {salesman2.Surname}. \nHe is {salesman2.Age} years old. \nHis position is {salesman2.Role}.\nHis salary is ${salesman2.Salary}.");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"The third employee is {salesman3.Name} {salesman3.Surname}. \nHe is {salesman3.Age} years old. \nHis position is {salesman3.Role}.\nHis salary is ${salesman3.Salary}.");
            Console.WriteLine("");

            // Assign developer to department
            department1.Developers = new Developer[] { developer1, developer2 };
            department1.Salesmen = new Salesman[] { salesman1, salesman2 };
            department1.GetSkillset();

            department2.Developers = new Developer[] { developer1 };
            department2.Salesmen = new Salesman[] { salesman3 };
            department2.GetSkillset();


            // Create two managers and assign each with department
            var manager1 = new Manager("Marjan", "Shapkaroski", 33);
            manager1.Department = department1;
            Console.WriteLine("");
            Console.WriteLine($"The first manager is {manager1.Name} {manager1.Surname}. \nHe is {manager1.Age} years old. \nHis salary is ${manager1.GetSalary()}");

            var manager2 = new Manager("Charlie", "Davidov", 33);
            manager2.Department = department2;
            Console.WriteLine($"The soncd manager is {manager2.Name} {manager2.Surname}. \nHe is {manager2.Age} years old. \nHis salary is ${manager2.GetSalary()}");

            // Print the sales revenue for both of the departments
            Console.WriteLine("");
            Console.WriteLine($"The sales Revenue of the first department is {department1.GetRevenue()}");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"The sales Revenue of the second department is {department2.GetRevenue()}");
            Console.WriteLine("");
            Console.WriteLine();

            // First Departement Salarys 
            for (int i = 0; i < department1.Salesmen.Length; i++)
            {
                Console.WriteLine($"First Department.The salary of the Salesman No.{i + 1} is: {department1.Salesmen[i].GetSalary()}");
            }
            Console.WriteLine();


            // Print the skillsets of the department
            Console.WriteLine();
            Console.WriteLine("*** First department ***");
            department1.GetSkillset();

            // Print the skillsets of the department
            Console.WriteLine();
            Console.WriteLine("*** Second department ***");
            department2.GetSkillset();
            Console.WriteLine("");

            // Print the salary of all salesman working in the department of the second manager
            for (int i = 0; i < department2.Salesmen.Length; i++)
            {
                Console.WriteLine($"Second Department.The salary of the Salesman No.{i + 1} is: {department2.Salesmen[i].GetSalary()}");
            }

            // Print the salary of the first manager
            Console.WriteLine($"The first manager has ${manager1.GetSalary()} salary");

        }
    }
}
