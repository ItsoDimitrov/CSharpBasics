using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.CompanyRoster
{
    class CompanyRoster
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            for (int i = 1; i <= n; i++)
            {
                List<string> employeeTokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                Employee employee = new Employee(employeeTokens[0], decimal.Parse(employeeTokens[1]), employeeTokens[2], employeeTokens[3]);
                if (employeeTokens.Count >= 5 && employeeTokens.Count <= 5) // Check if email is passed
                {
                    int age;
                    bool success = int.TryParse(employeeTokens[4], out age);
                    if (success)
                    {
                        employee.age = age;
                        employee.email = "n/a";
                    }
                    else
                    {
                        employee.email = employeeTokens[4];
                        employee.age = -1;
                    }
                }
                else if (employeeTokens.Count >= 6 && employeeTokens.Count <= 6)
                {
                    employee.email = employeeTokens[4];
                    employee.age = int.Parse(employeeTokens[5]);
                }
                else if (employeeTokens.Count >= 4 && employeeTokens.Count <= 4)
                {
                    employee.email = "n/a";
                    employee.age = -1;
                }
                employees.Add(employee);
            }
            var highestAverageSalaryDepartment = employees.GroupBy(e => e.department).Select(c => new
            {
                Department = c.Key,
                Employees = c.OrderByDescending(e => e.salary)


            }).FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {highestAverageSalaryDepartment.Department}");


            foreach (var employee in highestAverageSalaryDepartment.Employees)
            {
                Console.WriteLine($"{employee.name} {employee.salary:F2} {employee.email} {employee.age}");
            }
        }
    }
}
