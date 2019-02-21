using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer d = new Developer(3, "abc", "Senior Developer", 5, 8000, new DateTime(2019, 01, 01));
            Console.WriteLine("Salary Of Devloper : " + d.Annualsalary);

            HR h = new HR(9, "xyz", "Senior HR", 4, 8000, new DateTime(2019, 01, 01));
            Console.WriteLine("Salary Of HR : " + h.Annualsalary);

            Console.ReadKey();
        }
    }
}
