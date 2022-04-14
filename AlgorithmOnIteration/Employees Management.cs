using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AlgorithmOnIteration
{
    public class Solution
    {
        public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
        {
            List<EmployeeCount> employeeCount = new List<EmployeeCount>();
            Dictionary<string, int> result = new Dictionary<string, int>();
            for (int i = 0; i < employees.Count(); i++)
            {
                if(!employeeCount.Any(x => x.Company == employees[i].Company))
                {
                    employeeCount.Add(new EmployeeCount { Company = employees[i].Company, TotalAge = employees[i].Age, TotalCount = 1 });
                }
                else
                {
                    var employee = employeeCount.Where(x => x.Company == employees[i].Company).FirstOrDefault();
                    employee.TotalAge += employees[i].Age;
                    employee.TotalCount += 1;
                }
            }
            foreach(var employeeC in employeeCount)
            {
                result.Add(employeeC.Company, (int)Math.Ceiling((double)employeeC.TotalAge/(double)employeeC.TotalCount));
            }
            return result;
        }

        public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            for (int i = 0; i < employees.Count(); i++)
            {
                if (!result.ContainsKey(employees[i].Company))
                {
                    result.Add(employees[i].Company, 1);
                }
                else
                {
                    var existing = result.Where(x => x.Key == employees[i].Company).FirstOrDefault();
                    result[employees[i].Company] = existing.Value + 1;
                }
            }
            return result;
        }

        public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
        {
            Dictionary<string, Employee> result = new Dictionary<string, Employee>();
            for (int i = 0; i < employees.Count(); i++)
            {
                if (!result.ContainsKey(employees[i].Company))
                {
                    result.Add(employees[i].Company, employees[i]);
                }
                else
                {
                    var existing = result.Where(x => x.Key == employees[i].Company).FirstOrDefault();
                    if(employees[i].Age > existing.Value.Age)
                        result[employees[i].Company] = employees[i];
                }
            }
            return result;
        }
        //public static void Main()
        //{
        //    int countOfEmployees = int.Parse(Console.ReadLine());

        //    var employees = new List<Employee>();

        //    for (int i = 0; i < countOfEmployees; i++)
        //    {
        //        string str = Console.ReadLine();
        //        string[] strArr = str.Split(' ');
        //        employees.Add(new Employee
        //        {
        //            FirstName = strArr[0],
        //            LastName = strArr[1],
        //            Company = strArr[2],
        //            Age = int.Parse(strArr[3])
        //        });
        //    }

        //    foreach (var emp in AverageAgeForEachCompany(employees))
        //    {
        //        Console.WriteLine($"The average age for company {emp.Key} is {emp.Value}");
        //    }

        //    foreach (var emp in CountOfEmployeesForEachCompany(employees))
        //    {
        //        Console.WriteLine($"The count of employees for company {emp.Key} is {emp.Value}");
        //    }

        //    foreach (var emp in OldestAgeForEachCompany(employees))
        //    {
        //        Console.WriteLine($"The oldest employee of company {emp.Key} is {emp.Value.FirstName} {emp.Value.LastName} having age {emp.Value.Age}");
        //    }
        //}
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }
    }
    public class EmployeeCount 
    {
        public string Company { get; set; }
        public int TotalAge { get; set; }
        public int TotalCount { get; set; }
    }

}
