using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    abstract class Employee
    {
        private int Id;
        private string Name;
        private string Designation;
        private int Experience;
        public long Annualsalary;
        private DateTime joiningdate;

        public Employee(int id, string name, string designation, int experience, long BaseSalary, DateTime joiningdate)
        {
            this.Id = id;
            this.Name = name;
            this.Designation = designation;
            this.Experience = experience;
            Salarycalculator(BaseSalary, Experience);
            this.joiningdate = joiningdate;
        }
        public abstract void Salarycalculator(long BaseSalary, int Experience);
      
    }
}
