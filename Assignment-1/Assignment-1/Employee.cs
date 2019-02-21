using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Employee
    {
        private string Id;
        private string Name;
        private string DepartmentName;

        public Employee(string id, string name, string departmentName)
        {
            this.Id = id;
            this.Name = name;
            this.DepartmentName = departmentName;
        }

        public string GetId()
        {
            OnMethodCall("\nGetId() method called");
            return this.Id;
        }
        public string GetName()
        {
            OnMethodCall("GetName() method called");
            return this.Name;
        }
        public string GetDepartmentName()
        {
            OnMethodCall("GetDepartmentName() method called");
            return this.DepartmentName;
        }

        public delegate void OnMethodCallDelegate(string message);
        public event OnMethodCallDelegate MethodCallEvent;

        protected virtual void OnMethodCall(string message)
        {
            MethodCallEvent?.Invoke(message);
        }

        public void UpdateEmployee(string Id)
        {
            this.Id = Id;
        }
        public void UpdateEmployee(string Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public void UpdateEmployee(string Id, string Name, string Departmentname)
        {
            this.Id = Id;
            this.Name = Name;
            this.DepartmentName = Departmentname;
        }
    }

}
