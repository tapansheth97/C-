using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
	 class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Employee Details");
            Console.Write("\nEnter ID : ");
            string id = Console.ReadLine();
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Department Name : ");
            string departmentName = Console.ReadLine();
           
            Employee e = new Employee(id, name, departmentName);

            e.MethodCallEvent += EmployeeMethodCallEvent;

            Console.WriteLine("\nID:{0} \nName:{1} \nDepartment Name:{2}", e.GetId(), e.GetName(), e.GetDepartmentName());
            Console.ReadKey();
        }

        private static void EmployeeMethodCallEvent(string message)
        {
            Console.WriteLine(message);
        }
    }
}

