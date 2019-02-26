﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    public class Program
    {
        IList<Employee> employeeList;
        IList<Salary> salaryList;

        public Program()
        {
            employeeList = new List<Employee>() {
            new Employee(){ EmployeeID = 1, EmployeeFirstName = "Rajiv", EmployeeLastName = "Desai", Age = 49},
            new Employee(){ EmployeeID = 2, EmployeeFirstName = "Karan", EmployeeLastName = "Patel", Age = 32},
            new Employee(){ EmployeeID = 3, EmployeeFirstName = "Sujit", EmployeeLastName = "Dixit", Age = 28},
            new Employee(){ EmployeeID = 4, EmployeeFirstName = "Mahendra", EmployeeLastName = "Suri", Age = 26},
            new Employee(){ EmployeeID = 5, EmployeeFirstName = "Divya", EmployeeLastName = "Das", Age = 20},
            new Employee(){ EmployeeID = 6, EmployeeFirstName = "Ridhi", EmployeeLastName = "Shah", Age = 60},
            new Employee(){ EmployeeID = 7, EmployeeFirstName = "Dimple", EmployeeLastName = "Bhatt", Age = 53}
        };

            salaryList = new List<Salary>() {
            new Salary(){ EmployeeID = 1, Amount = 1000, Type = SalaryType.Monthly},
            new Salary(){ EmployeeID = 1, Amount = 500, Type = SalaryType.Performance},
            new Salary(){ EmployeeID = 1, Amount = 100, Type = SalaryType.Bonus},
            new Salary(){ EmployeeID = 2, Amount = 3000, Type = SalaryType.Monthly},
            new Salary(){ EmployeeID = 2, Amount = 1000, Type = SalaryType.Bonus},
            new Salary(){ EmployeeID = 3, Amount = 1500, Type = SalaryType.Monthly},
            new Salary(){ EmployeeID = 4, Amount = 2100, Type = SalaryType.Monthly},
            new Salary(){ EmployeeID = 5, Amount = 2800, Type = SalaryType.Monthly},
            new Salary(){ EmployeeID = 5, Amount = 600, Type = SalaryType.Performance},
            new Salary(){ EmployeeID = 5, Amount = 500, Type = SalaryType.Bonus},
            new Salary(){ EmployeeID = 6, Amount = 3000, Type = SalaryType.Monthly},
            new Salary(){ EmployeeID = 6, Amount = 400, Type = SalaryType.Performance},
            new Salary(){ EmployeeID = 7, Amount = 4700, Type = SalaryType.Monthly}
        };
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            program.Task1();
            program.Task2();
            program.Task3();
        }
        public void Task1()
        {
            Console.WriteLine("Total Salary of all the employee with their corresponding names in ascending order of their salary:");
            var Salarydetails = from salary in salaryList
                              group salary by salary.EmployeeID into sgroup
                              select new
                              {
                                  eid = sgroup.Key,
                                  totalsalary = (sgroup.Aggregate((monthly,bonus) => new Salary { EmployeeID = monthly.EmployeeID, Amount = monthly.Amount + bonus.Amount })).Amount
                              };

            var query = employeeList.Join(Salarydetails, e => e.EmployeeID, s => s.eid, (e, s) => new{e = e,s = s})
                      .OrderBy(result => result.s.totalsalary);

            foreach (var item in query)
            {
                Console.WriteLine($"First Name: {item.e.EmployeeFirstName}\tLast Name: {item.e.EmployeeLastName}  \tMonthly Salary: {item.s.totalsalary}");
            }
        }

        public void Task2()
        {
            Console.WriteLine("\nEmployee details of 2nd oldest employee including his/her total monthly salary:");
            var query = employeeList.Join(salaryList, e => e.EmployeeID, s => s.EmployeeID, (e, s) => new{e = e,s = s})
                       .Where(result => result.s.Type.Equals(SalaryType.Monthly)).OrderByDescending(result => result.e.Age).Take(2).Skip(1);

            foreach (var item in query)
            {
                Console.WriteLine($"ID: {item.e.EmployeeID}\tFirst Name: {item.e.EmployeeFirstName}\tLast Name: {item.e.EmployeeLastName}\tAge: {item.e.Age} \tMonthly Salary: {item.s.Amount}");
            }
        }

        public void Task3()
        {
            Console.WriteLine("\nMean of Monthly, Performance, Bonus salary of employees whose age is greater than 30:");
            var query = employeeList.Join(salaryList, e => e.EmployeeID, s => s.EmployeeID, (e, s) => new{e = e,s = s})
                        .Where(result => result.e.Age > 30);

            var m = 0;
            var b = 0;
            var p = 0;

            foreach (var item in query)
            {
                if (item.s.Type.Equals(SalaryType.Monthly))
                {
                    m += item.s.Amount;
                }
                if (item.s.Type.Equals(SalaryType.Bonus))
                {
                    b += item.s.Amount;
                }
                if (item.s.Type.Equals(SalaryType.Performance))
                {
                    p += item.s.Amount;
                }
            }

            int temp = query.GroupBy(item => item.e.EmployeeID).Count();
            Console.WriteLine($"Monthly salary: {m / temp},\nBonus salary: {b / temp},\nPerformance salary: {p / temp}");
            Console.ReadKey();
        }
    }
    public enum SalaryType
    {
        Monthly,
        Performance,
        Bonus
    }

    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public int Age { get; set; }
    }

    public class Salary
    {
        public int EmployeeID { get; set; }
        public int Amount { get; set; }
        public SalaryType Type { get; set; }
    }
}