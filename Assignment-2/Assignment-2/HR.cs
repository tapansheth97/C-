using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class HR : Employee
    {
        public HR(int id, string name, string designation, int experience, long BaseSalary, DateTime joiningDate) : base(id, name, designation, experience, BaseSalary, joiningDate)
        {
        }
        public override void Salarycalculator(long BaseSalary, int Experience)
        {
            this.Annualsalary = BaseSalary + (Experience * 1000);
        }
    }
}
